using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Entities;
using VTC.Data.Repositories.Interfaces;
using VTC.Data;

namespace VTC.Data.Repositories
{
    public class LevelRepository : ILevelRepository
    {
        private readonly VTCDataContext _context;
        public LevelRepository(VTCDataContext context)
        {
            _context = context;
        }
        public void Add(Level model)
        {
            _context.Levels.Add(model);
        }

        public void Update(Level model)
        {
            var entity = _context.Levels.FirstOrDefault(e => e.Id == model.Id);
            entity.Title = model.Title;
            entity.PackageId = model.PackageId;
            
        }
    }
}
