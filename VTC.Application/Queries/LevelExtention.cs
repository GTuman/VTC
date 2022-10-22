using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.ViewModels;
using Microsoft.EntityFrameworkCore;
using VTC.Data.Entities;


namespace VTC.Application.Queries
{
    public static class LevelExtention
    {
        public static List<LevelVM> GetAlllevels(this DbSet<Level> db , int? packageId =null)
        {
            var data = db.Where(p => !packageId.HasValue
            || p.PackageId == packageId)
               .Select(p => new LevelVM
                {
                    Id=p.Id,
                    Title=p.Title,
                    PackageName = p.Package.Title,
                    SubjectCount = p.Subjects.Count()
                })
               .AsSplitQuery()
               .AsNoTracking().ToList();

            return data;
        }
        public static LevelAddEditVM GetForEdit(this DbSet<Level> db, int levelId)
        {
            var data = db.Where(p => p.Id == levelId)
                .Select(p => new LevelAddEditVM
                {
                    Id = p.Id,
                    Title = p.Title,
                    PackageId = p.PackageId
                }).FirstOrDefault();
            return data;
        }
        public static LevelInfoVM GetById(this DbSet<Level> db, int levelId)
        {
            var LevelDb = db.Where(l => l.Id == levelId).
                Select(l => new LevelInfoVM
                {
                    Id = l.Id
                 ,
                    Title = l.Title,
                    PackageName = l.Package.Title,
                    SubjectList = l.Subjects.Where(l => l.LevelId == levelId).Select(l => l.Name).ToList()
                }).AsNoTracking().FirstOrDefault();
            return LevelDb;
        }
       

      
        
    }
}
