﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Challenges.StacksQueues;

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
    }
}
