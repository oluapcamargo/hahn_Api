using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hahn.ApplicatonProcess.February2021.Persistence.Model
{
    public static class ModelCreationExtension
    {
        public static void ApplyHannConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssetConfig());
        }
    }
}
