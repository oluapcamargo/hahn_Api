using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hahn.ApplicatonProcess.February2021.Domain.Enum
{
    public enum EnumDepartment
    {
        [Description("HQ")] HQ,
        [Description("Store1")] Store1,
        [Description("Store2")] Store2,
        [Description("Store3")] Store3,
        [Description("MaintenanceStation")] MaintenanceStation,
    }
}
