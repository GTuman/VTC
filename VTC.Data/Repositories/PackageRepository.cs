using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Repositories.Interfaces;
using VTC.Data.Entities;
using VTC.Data;
namespace VTC.Data.Repositories
{
    public class PackageRepository:IPackageRepository
    {
        private readonly VTCDataContext _context;
        public PackageRepository(VTCDataContext context)
        {
            _context = context;
        }

        public void Add(Package package)
        {
            _context.Packages.Add(package);
        }
         public void Update(Package package)
        {
            var entity = _context.Packages.FirstOrDefault(p => p.Id == package.Id);
            entity.Title = package.Title;
        }
    }
}
