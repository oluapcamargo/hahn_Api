using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using MediatR;

namespace Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput
{
    public class GetAssetInput : IRequest<Result<Asset>>
    {
        public int Id { get; set; }
    }
}
