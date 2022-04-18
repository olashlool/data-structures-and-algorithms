using System;

namespace Animal_Shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter a = new AnimalShelter();
            a.Enqueue(new Animal("Dog"));
            a.Enqueue(new Animal("Cat"));
            a.Enqueue(new Animal("Cat"));
            a.Enqueue(new Animal("Cat"));
            a.Enqueue(new Animal("Dog"));
            a.Enqueue(new Animal("Dog"));

            a.Print();
            a.Dequeue("cat");
            a.Print();
            a.Dequeue("dog");
            a.Print();

        }

    }
}
