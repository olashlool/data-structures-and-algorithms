using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class PseudoQueue
    {
        public Stack Stack1 = new Stack();
        public Stack Stack2 = new Stack();

        // Stack push() method works the same as Enqueue() by simply adding a new node to the rear which is equal to top
        public void Enqueue(int value)
        {
            Stack1.Push(value);
        }

        // Dequeue() by popping all but the last node and pushing into a temp stack, pushing it all again to a new stack, then reassigning it back to the PseudoQueue stack.
         public int Dequeue()
         {
             int temp;
             // If Stack1 only has one node, pop it and return its value.
             if (Stack1.Top.Next == null)
             {
                 temp = Stack1.Pop();
                 return temp;
             }
             // Moves all but the dequeued node to temp stack2
             while (Stack1.Top != null)
             {
                 Stack2.Push(Stack1.Pop());
             }
             // Stores the value of the dequeued node
             temp = Stack2.Pop();
             // Moves all the nodes from stack2 to stack1 "original order"
             while (Stack2.Top != null)
             {
                 Stack1.Push(Stack2.Pop());
             }
             return temp;
         }
    }
}
