using System;

namespace Stack_Queue_Pseudo
{
    public class Program
    {
        static void Main(string[] args)
        {
            PseudoQueue q = new PseudoQueue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Dequeue();
            Console.WriteLine(q.Dequeue());
        }

    }
}
