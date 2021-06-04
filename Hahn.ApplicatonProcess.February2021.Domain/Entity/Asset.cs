using Hahn.ApplicatonProcess.February2021.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hahn.ApplicatonProcess.February2021.Domain.Entity
{
    public class Asset
    {
        public int Id { get; set; }
        [MinLength(5)]
        public string AssetName { get; set; }
        [Required(ErrorMessage = "Must be a valid Department.")]
        public EnumDepartment Department { get; set; }
        public string CountryOfDepartment { get; set; }
        public string EMailAdressOfDepartment { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool Broken { get; set; } = false;
    }
}
