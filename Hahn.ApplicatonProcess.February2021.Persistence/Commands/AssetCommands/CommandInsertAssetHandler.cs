using FluentValidation.Results;
using Hahn.ApplicatonProcess.February2021.Data.Service;
using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Hahn.ApplicatonProcess.February2021.Domain.Interface;
using Hahn.ApplicatonProcess.February2021.Domain.Validator;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output.AssetOutput;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Data.Commands.AssetCommands
{
    public class CommandInsertAssetHandler : IRequestHandler<InsertAssetInput, Result<InsertAssetOutput>>
    {
        private readonly IAssetRepository _repository;
        public CommandInsertAssetHandler(IAssetRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<InsertAssetOutput>> Handle(InsertAssetInput request, CancellationToken cancellationToken)
        {
            var result = new Result<InsertAssetOutput>();
            AssetValidator validator = new AssetValidator();
            ValidadeCountryDepartament validadeCountry = new ValidadeCountryDepartament();

            var assetInsert = new Asset() 
                {
                    AssetName = request.AssentName,
                    Broken = request.Broken,
                    CountryOfDepartment = await validadeCountry.GetCountryDepartament(request.CountryDepartment),
                    Department = request.Department,
                    EMailAdressOfDepartment = request.EmailDepartment,
                    PurchaseDate = request.PurchaseDate
                };
            
            ValidationResult results = validator.Validate(assetInsert);
            if (results.IsValid)
            {
                await _repository.AddAsync(assetInsert);
                result.HttpStatusCode = System.Net.HttpStatusCode.Created;
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    result.WithError("Error on  " + item.PropertyName +" ; Error Message : " + item.ErrorMessage);
                }
            }
            return result;
        }
    }
}
