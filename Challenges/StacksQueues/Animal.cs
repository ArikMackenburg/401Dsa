using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Challenges.StacksQueues
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract AnimalType Type { get; }

    }
    public enum AnimalType
    {
        Cat,
        Dog,
    }

    public class Cat : Animal
    {
        public Cat(string name)
        {
            this.Name = name;

        }

        public override AnimalType Type => AnimalType.Cat;

        

    }
    public class Dog : Animal
    {
        public Dog(string name)
        {
            this.Name = name;
            
        }

        public override AnimalType Type => AnimalType.Dog;
   
    }
   
}
