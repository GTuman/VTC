using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Repositories.Interfaces;
using VTC.Data;
namespace VTC.Data.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly VTCDataContext _context;
        public UnitOfWork(VTCDataContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
