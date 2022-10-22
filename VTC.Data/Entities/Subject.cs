using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace VTC.Data.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LevelId { get; set; }
        [ForeignKey("LevelId")]
        public Level Level { get; set; }
        public string Description { get; set; }
        public string? LogoFile { get; set; }
    }
}
