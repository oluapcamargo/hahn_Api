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
            RuleFor(asset => asset.AssetName).MinimumLength(5).WithMessage("Asset Name must have more than 5 letters;");
            RuleFor(asset => asset.Department).IsInEnum().WithMessage("Department is not valid;");
            RuleFor(asset => asset.PurchaseDate).GreaterThan(DateTime.Now.AddYears(-1)).WithMessage("Purchase Date must be greater than " + DateTime.Now.AddYears(-1).ToShortDateString()); ;
            RuleFor(asset => asset.EMailAdressOfDepartment).EmailAddress().WithMessage("Email Adress is not valid;");
            RuleFor(asset => asset.CountryOfDepartment).NotNull().WithMessage("Country is not valid;");
        }
    }
}
