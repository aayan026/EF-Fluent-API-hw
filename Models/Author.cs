using Lesson_4_EntityFrameworkCodeFirst.Models.Base;

namespace Fulent_API.Models
{
    internal class Author :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
