using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;
using VTC.Application.Queries;
using VTC.Data;
using VTC.Data.Entities;
using VTC.Data.Repositories.Interfaces;
namespace VTC.Application.Services
{
    public class PackageService : IPackageService
    {
        private readonly VTCDataContext _context;
        private readonly IUnitOfWork _uow;
        private readonly IPackageRepository _packageRepository;
        public PackageService(VTCDataContext context, IPackageRepository packageRepository, IUnitOfWork unitOfWork)
        {
            _context = context;
            _packageRepository = packageRepository;
            _uow = unitOfWork;

        }
        public void Add(PackageVM model)
        {
            Package package = new();
            package.Title = model.Title;
            _packageRepository.Add(package);
            _uow.Save();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PackageVM> GetAllPackages()
        {
            return _context.Packages.GetAllPackages();
        }

        public PackageVM GetById(int id)
        {
            return _context.Packages.GetById(id);
        }

        public void Update(PackageVM model)
        {
            Package package = new();
            package.Title = model.Title;
            package.Id = model.Id;
            _packageRepository.Update(package);
            _uow.Save();
        }
    }
}
