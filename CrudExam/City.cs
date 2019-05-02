using System.Collections.Generic;

namespace CrudExam
{
    public class City : Entity
    {
        public string Name { get; set; }
        public ICollection<Street> streets { get; set; }
    }
}
