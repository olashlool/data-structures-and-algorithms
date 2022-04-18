using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter
{
    public class Animal
    {
        public string Name { get; set; }
        public Animal Next { get; set; }

        public Animal(string animal)      // Creates new animal with Value
        {
            if (animal != null) animal = animal.ToUpper();
            Name = animal;
            Next = null;
        }
    }
}
