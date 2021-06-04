using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Hahn.ApplicatonProcess.February2021.Domain.Enum;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using MediatR;
using System;

namespace Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput
{
    public class UpdateAssetInput : IRequest<Result>
    {
        public Asset Asset { get; set; }
    }
}
