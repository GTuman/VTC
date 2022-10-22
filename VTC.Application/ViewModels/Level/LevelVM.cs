using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTC.Application.ViewModels
{
    public class LevelVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PackageName { get; set; }
        public int SubjectCount { get; set; }
    }
    public class LevelInfoVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PackageName { get; set; }
        public List<string> SubjectList { get; set; }
    }
}