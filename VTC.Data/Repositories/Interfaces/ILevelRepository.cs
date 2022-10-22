using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Entities;

namespace VTC.Data.Repositories.Interfaces
{
    public interface ILevelRepository
    {
        void Add(Level model);
        void Update(Level model);

    }
}
