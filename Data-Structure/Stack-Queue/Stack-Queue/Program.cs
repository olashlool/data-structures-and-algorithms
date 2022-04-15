using System;

namespace Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============= Stacks =============");
            Console.WriteLine();
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"| {myStack.Peek().Value} | ");
                myStack.Pop();

            }
            Console.WriteLine($"|___|");

            Console.WriteLine("============= Queues =============");
            Console.WriteLine();
            Queue myQueue = new Queue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"| {myQueue.Peek().Value} | ");
               Node removedNode = myQueue.Dequeue();
            }
            Console.WriteLine($"|___|");

            Console.WriteLine("============= Pseudo Queue =============");
            Console.WriteLine();
            PseudoQueue PseudoQueue = new PseudoQueue();
            PseudoQueue.Enqueue(1);
            PseudoQueue.Enqueue(2);
            PseudoQueue.Enqueue(3);
            PseudoQueue.Enqueue(4);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"| {PseudoQueue.Dequeue()} | ");
            }
            Console.WriteLine($"|___|");

        }
    }
}

