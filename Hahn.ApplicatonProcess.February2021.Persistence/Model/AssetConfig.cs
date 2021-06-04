using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hahn.ApplicatonProcess.February2021.Persistence.Model
{
    public class AssetConfig : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder) 
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).HasColumnName("CD_ID").IsRequired().ValueGeneratedOnAdd();

            builder.Property(p => p.Department).HasColumnName("TX_DEPARTMENT").IsRequired();
            
            builder.Property(p => p.AssetName).HasColumnName("TX_NAME").IsRequired();

            builder.Property(p => p.CountryOfDepartment).HasColumnName("TX_COUNTRY_DEPARTMENT").HasColumnType("varchar(1000)").HasMaxLength(1000);

            builder.Property(p => p.EMailAdressOfDepartment).HasColumnName("TX_DEPARTMENT_EMAIL");

            builder.Property(p => p.PurchaseDate).HasColumnName("DT_PURCHASE").IsRequired();

            builder.Property(p => p.Broken).HasColumnName("BL_BROKEN").HasDefaultValueSql("false").IsRequired();
        }
    }
}
