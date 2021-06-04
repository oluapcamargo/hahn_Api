using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Hahn.ApplicatonProcess.February2021.Persistence.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hahn.ApplicatonProcess.February2021.Persistence.Context
{
    public class HannContext : DbContext
    {
        public HannContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Asset> Asset { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyHannConfiguration();

        }
    }
}
