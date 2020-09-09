
using DataStructures.StacksQueues;
using System.Collections;


namespace Challenges.StacksQueues
{
    public class AnimalShelter<T> where T : Animal
    {
        private DataStructures.StacksQueues.Queue<T> Animals = new DataStructures.StacksQueues.Queue<T>();

        public void Enqueue(T animal)
        {
            Animals.EnQueue(animal);
        }



        public T DeQueue(AnimalType type)
        {
          
            Node<T> result = new Node<T>();
            DataStructures.StacksQueues.Queue<T> temp = new DataStructures.StacksQueues.Queue<T>();
            switch (type)
            {
                case AnimalType.Cat:
                    
                    while (Animals.isEmpty() == false)
                    {
                        T front = Animals.Peek();
                        if (front.Type == AnimalType.Cat)
                        {
                            result.Value = Animals.DeQueue();
                            while (Animals.isEmpty() == false)
                                temp.EnQueue(Animals.DeQueue());
                            break;
                        }

                        temp.EnQueue(Animals.DeQueue());
                    }
                    Animals = temp;
                    return result.Value;

                    

                case AnimalType.Dog:
                    
                    while (Animals.isEmpty() == false)
                    {
                        T front = Animals.Peek();
                        if (front.Type == AnimalType.Dog)
                        {
                            result.Value = Animals.DeQueue();
                            while (Animals.isEmpty() == false)
                                temp.EnQueue(Animals.DeQueue());
                            break;
                        }

                        temp.EnQueue(Animals.DeQueue());
                    }
                    Animals = temp;

                    return result.Value;
            }
            throw new TypeNotFoundException();
        }

        public T DeQueue()
        {
            return Animals.DeQueue();
        }

        public override string ToString()
        {
            Node<T> current = Animals.Front;
            string result = "";
            while (current != null)
            {
                result = $"{result}{{ {current.Value.Name} }} -> ";
                current = current.Next;

            }

            return $"{result}NULL";
        }

        
    }
}
