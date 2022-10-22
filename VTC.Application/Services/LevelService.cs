using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;
using VTC.Data;
using VTC.Application.Queries;
using VTC.Data.Repositories.Interfaces;
using VTC.Data.Entities;

namespace VTC.Application.Services
{
    public class LevelService : ILevelService
    {
        private readonly VTCDataContext _context;
        private readonly ILevelRepository _levelRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LevelService(VTCDataContext context, ILevelRepository levelRepository, IUnitOfWork unitOfWork)
        {
            _context = context;
            _levelRepository = levelRepository;
            _unitOfWork = unitOfWork;
        }


        public void Add(LevelAddEditVM levelModel)
        {
            var level = new Level()
            {
                Title = levelModel.Title,
                PackageId = levelModel.PackageId
            };
            _levelRepository.Add(level);
            _unitOfWork.Save();
        }


        public List<LevelVM> GetAllLevels(int? packageId)
        {
            return _context.Levels.GetAlllevels(packageId);
        }

        public LevelAddEditVM GetForEdit(int levelid)
        {
            return _context.Levels.GetForEdit(levelid);
        }

        public LevelInfoVM GetInfoById(int levelid)
        {
            var Info = _context.Levels.GetById(levelid);
            return Info;
        }

        public void Update(LevelAddEditVM levelModel)
        {
            
            var level = new Level()
            {
                Title = levelModel.Title,
                PackageId = levelModel.PackageId,
                Id = levelModel.Id
            };
            _levelRepository.Update(level);
            _unitOfWork.Save();
        }

    }
}
