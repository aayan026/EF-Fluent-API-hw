using Lesson_4_EntityFrameworkCodeFirst.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulent_API.Models
{
    internal class T_Card : BaseEntity
    {
        public int Id_Teacher { get; set; }
        public int Id_Book { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int Id_lib { get; set; }
    }
}
