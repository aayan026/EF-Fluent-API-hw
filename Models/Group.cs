using Lesson_4_EntityFrameworkCodeFirst.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulent_API.Models
{
    internal class Group : BaseEntity
    {
        public string Name { get; set; }
        public int Id_Faculty { get; set; }
    }
}
