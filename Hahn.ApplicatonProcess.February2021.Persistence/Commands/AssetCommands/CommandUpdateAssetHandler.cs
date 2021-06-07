using FluentValidation.Results;
using Hahn.ApplicatonProcess.February2021.Domain.Interface;
using Hahn.ApplicatonProcess.February2021.Domain.Validator;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Data.Commands.AssetCommands
{
    public class CommandUpdateAssetHandler : IRequestHandler<UpdateAssetInput, Result>
    {
        private readonly IAssetRepository _repository;
        public CommandUpdateAssetHandler(IAssetRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result> Handle(UpdateAssetInput request, CancellationToken cancellationToken)
        {
            var result = new Result();
            AssetValidator validator = new AssetValidator();
            ValidationResult results = validator.Validate(request.Asset);
            if (results.IsValid)
            {
                var asset = await _repository.GetAsync(request.Asset.Id);
                if(asset != null) 
                {
                    asset.AssetName = request.Asset.AssetName;
                    asset.Broken = request.Asset.Broken;
                    asset.CountryOfDepartment = request.Asset.CountryOfDepartment;
                    asset.Department = request.Asset.Department;
                    asset.EMailAdressOfDepartment = request.Asset.EMailAdressOfDepartment;
                    asset.PurchaseDate = request.Asset.PurchaseDate;
                    await _repository.UpdateAsync(asset);
                }
                else
                {
                    result.Errors.Add("Asset Not found;");
                }
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    result.WithError("Error on  " + item.PropertyName + " ; Error Message : " + item.ErrorMessage);
                }
            }
            return result;
        }
    }
}
