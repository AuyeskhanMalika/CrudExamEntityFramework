using System.Collections.Generic;

namespace CrudExam
{
    public class Street : Entity
    {
        public string Name { get; set; }
        public ICollection<City> cities { get; set; }
    }
}
