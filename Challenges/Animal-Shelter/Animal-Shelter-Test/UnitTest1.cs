using System;
using Xunit;
using Animal_Shelter;
namespace Animal_Shelter_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueueInvalidAnimal()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Ferret"));
            Assert.Null(shelter.Front);
        }

        [Fact]
        public void TestEnqueue()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Cat"));
            Assert.Equal("CAT", shelter.Front.Name);
        }

        [Fact]
        public void TestMultiEnqueue()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            Assert.Equal("CAT", shelter.Rear.Name);
        }

        [Fact]
        public void TestShelterCounter()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            Assert.Equal(2, shelter.Total);
        }

        [Fact]
        public void TestDequeueInvalidAnimal()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            Assert.Null(shelter.Dequeue("ferret").Name);
        }

        [Fact]
        public void TestDequeueMatch()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            Assert.Equal("CAT", shelter.Dequeue("cat").Name);
        }

        [Fact]
        public void TestCountAfterDequeueMatch()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Dequeue("cat");
            Assert.Equal(1, shelter.Total);
        }

        [Fact]
        public void TestFrontAfterDequeueMatch()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Cat"));
            shelter.Dequeue("dog");
            Assert.Equal("CAT", shelter.Front.Name);
        }

        [Fact]
        public void TestNoMatch()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            shelter.Enqueue(new Animal("Dog"));
            Assert.Null(shelter.Dequeue("cat").Name);
        }
    }
}
