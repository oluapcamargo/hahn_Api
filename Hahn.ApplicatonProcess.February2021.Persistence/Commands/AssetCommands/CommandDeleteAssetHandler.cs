using Hahn.ApplicatonProcess.February2021.Domain.Interface;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Data.Commands.AssetCommands
{
    public class CommandDeleteAssetHandler : IRequestHandler<DeleteAssetInput, Result>
    {
        private readonly IAssetRepository _repository;
        public CommandDeleteAssetHandler(IAssetRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result> Handle(DeleteAssetInput request, CancellationToken cancellationToken)
        {
            var result = new Result();

            var asset = await _repository.GetAsync(request.Id);
            if (asset != null)
            {
                await _repository.RemoveByIdAsync(asset.Id);
            }
            else
            {
                result.Errors.Add("Asset Not found;");
            }
            return result;
        }
    }
}
