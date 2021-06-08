using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using MediatR;
using System.Collections.Generic;

namespace Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput
{
    public class GetAllAssetInput : IRequest<Result<IEnumerable<Asset>>>
    {
    }
}
