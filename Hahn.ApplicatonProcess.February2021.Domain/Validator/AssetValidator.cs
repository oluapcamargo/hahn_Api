using FluentValidation;
using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Hahn.ApplicatonProcess.February2021.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hahn.ApplicatonProcess.February2021.Domain.Validator
{
    public class AssetValidator: AbstractValidator<Asset>
    {
        public AssetValidator()
        {
            RuleFor(asset => asset.AssetName).MinimumLength(5);
            RuleFor(asset => asset.Department).IsInEnum();
            RuleFor(asset => asset.PurchaseDate).GreaterThan(DateTime.Now.AddYears(-1));
            RuleFor(asset => asset.EMailAdressOfDepartment).EmailAddress();
        }
    }
}
