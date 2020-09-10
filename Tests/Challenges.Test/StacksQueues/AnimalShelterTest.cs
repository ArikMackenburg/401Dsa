using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Challenges.StacksQueues;
using DataStructures.StacksQueues;

namespace Challenges.Test.StacksQueues
{
    public class AnimalShelterTest
    {
        [Fact]
        public static void AnimalShelter_starts_empty()
        {
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();



            Assert.Equal("NULL", shelter.ToString());
        }

        [Fact]
        public static void EnQueue_adds_animals()
        {
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();

            shelter.Enqueue(new Dog("Melo"));
            shelter.Enqueue(new Dog("Remy"));
            shelter.Enqueue(new Cat("Misty"));



            Assert.Equal("{ Melo } -> { Remy } -> { Misty } -> NULL", shelter.ToString());
        }

        [Fact]
        public static void DeQueue_return_correct_type_cat()
        {
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();

            shelter.Enqueue(new Dog("Melo"));
            shelter.Enqueue(new Dog("Remy"));
            shelter.Enqueue(new Cat("Misty"));

            Animal misty = shelter.DeQueue(AnimalType.Cat);

            Assert.Equal("Misty", misty.Name);
        }

        [Fact]
        public static void DeQueue_return_correct_type_dog()
        {
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();

            shelter.Enqueue(new Dog("Melo"));
            shelter.Enqueue(new Dog("Remy"));
            shelter.Enqueue(new Cat("Misty"));

            Animal melo = shelter.DeQueue(AnimalType.Dog);

            Assert.Equal("Melo", melo.Name);
        }
        [Fact]
        public static void DeQueue_return_front()
        {
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();

            shelter.Enqueue(new Dog("Melo"));
            shelter.Enqueue(new Dog("Remy"));
            shelter.Enqueue(new Cat("Misty"));

            Animal melo = shelter.DeQueue();

            Assert.Equal("Melo", melo.Name);
        }
        [Fact]
        public void DeQueue_throws_EmptyEx_on_empty()
        {
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();

            Exception ex = Assert.Throws<EmptyQueueException>(() =>
            {
                shelter.DeQueue();
            });
            Assert.Equal("Queue is empty", ex.Message);
        }
        [Fact]
        public static void DeQueue_return_front_then_DeQueue_cat_returns_cat()
        {
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();

            shelter.Enqueue(new Dog("Melo"));
            shelter.Enqueue(new Dog("Remy"));
            shelter.Enqueue(new Cat("Misty"));

            Animal melo = shelter.DeQueue();
            Animal misty = shelter.DeQueue(AnimalType.Cat);

            Assert.Equal("Melo", melo.Name);
            Assert.Equal("Misty", misty.Name);
            Assert.Equal("{ Remy } -> NULL", shelter.ToString());
        }
    }
}
