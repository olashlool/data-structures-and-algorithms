using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public int Total;


        public void Enqueue(Animal newAnimal)
        {
            if (newAnimal.Name == "CAT" || newAnimal.Name == "DOG")
            {
                Total++;
                if (Front == null)
                {
                    Front = newAnimal;
                    Rear = newAnimal;
                    //Console.WriteLine(Rear.Name);
                }
                else
                {
                    Rear.Next = newAnimal;
                    Rear = newAnimal;
                    //Console.WriteLine(Rear.Name);
                }
            }
            else
            {
                Console.WriteLine("Sorry, this shelter holds only dogs and cats.");
            }
        }
        public Animal Dequeue(string pref)
        {
            Animal pet = new Animal(null);
            pref = pref.ToUpper();
            int count = 0;
            bool match = false;

            //Only cats and dogs allowed (or no preference)
            if (pref != "CAT" && pref != "DOG" && pref != "")
            {
                Console.WriteLine("Sorry, we only have cats and dogs available");
                return pet;
            }

            while (count < Total)
            {
                count++;
                //take front animal and make a temp animal
                Animal temp = Front;
                Front = Front.Next;
                temp.Next = null;

                //If animal is a match OR no preference in animal
                //and there has been no match already. If no preference,
                //this will return the oldest animal in the shelter
                if ((pref == "" || temp.Name == pref) && !match)
                {
                    pet = temp;
                    match = true;
                }
                else //put temp animal back into queue
                {
                    Total--;
                    Enqueue(temp);
                }
            }
            //return new pet
            Total--;
            return pet;
        }
        public void Print()
        {
            Animal current = Front;
            while (current.Next != null)
            {
                Console.Write($"{current.Name}-->");
                current = current.Next;
            }
            Console.Write($"{current.Name}-->");
            Console.Write("NULL");
            Console.WriteLine();
        }
    }

}


