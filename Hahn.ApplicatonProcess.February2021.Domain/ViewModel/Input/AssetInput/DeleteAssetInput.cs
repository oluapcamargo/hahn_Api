using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput
{
    public class DeleteAssetInput : IRequest<Result>
    {
        public int Id { get; set; }
    }
}
