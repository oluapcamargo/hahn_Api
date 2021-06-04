using Hahn.ApplicatonProcess.February2021.Domain.Enum;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output.AssetOutput;
using MediatR;
using System;

namespace Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput
{
    public class InsertAssetInput : IRequest<Result<InsertAssetOutput>>
    {
        public string AssentName { get; set; }
        public EnumDepartment Department { get; set; }
        public string CountryDepartment { get; set; }
        public string EmailDepartment { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool Broken { get; set; }
    }
}
