using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Hahn.ApplicatonProcess.February2021.Domain.Interface;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Data.Queries.AssetQueries
{
    public class QueryGetByIdAssetCommandHandler : IRequestHandler<GetAssetInput, Result<Asset>>
    {
        private readonly IAssetRepository _repository;

        public QueryGetByIdAssetCommandHandler(IAssetRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<Asset>> Handle(GetAssetInput request, CancellationToken cancellationToken)
        {
            var result = new Result<Asset>();
            result.Value = await _repository.GetAsync(request.Id);
            return result;
        }
    }
}
