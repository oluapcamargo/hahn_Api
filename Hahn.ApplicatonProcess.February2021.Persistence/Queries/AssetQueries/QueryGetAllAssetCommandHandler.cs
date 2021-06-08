using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Hahn.ApplicatonProcess.February2021.Domain.Interface;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Data.Queries.AssetQueries
{
    public class QueryGetAllAssetCommandHandler : IRequestHandler<GetAllAssetInput, Result<IEnumerable<Asset>>>
    {
        private readonly IAssetRepository _repository;

        public QueryGetAllAssetCommandHandler(IAssetRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<IEnumerable<Asset>>> Handle(GetAllAssetInput request, CancellationToken cancellationToken)
        {
            var result = new Result<IEnumerable<Asset>>();
            result.Value = await _repository.GetAllAsync();
            return result;
        }
    }
}
