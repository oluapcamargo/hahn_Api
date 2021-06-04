using Hahn.ApplicatonProcess.February2021.Data.Repository.Base;
using Hahn.ApplicatonProcess.February2021.Domain.Interface;
using Hahn.ApplicatonProcess.February2021.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hahn.ApplicatonProcess.February2021.Data.Repository
{
    public partial class AssetRepository : BaseRepository<Domain.Entity.Asset>, IAssetRepository
    {
        public HannContext _context => DatabaseContext as HannContext;
        public AssetRepository(HannContext context) : base(context) { }
    }
}
