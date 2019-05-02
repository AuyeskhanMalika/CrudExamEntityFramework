using System.Collections.Generic;

namespace CrudExam
{
    public class Country : Entity
    {
        public string Name { get; set; }
        public ICollection<City> cities { get; set; }
    }
}
