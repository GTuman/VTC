using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.ViewModels;
namespace VTC.Application.Services.Interfaces
{
    public interface IPackageService
    {
        List<PackageVM> GetAllPackages();
        void Add(PackageVM model);
        void Update(PackageVM model);
        PackageVM GetById(int id);
        void Delete(int id);
    }
}
