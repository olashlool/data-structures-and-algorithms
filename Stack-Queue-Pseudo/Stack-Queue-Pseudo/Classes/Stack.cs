using System;

namespace Stack_Queue_Pseudo
{
    public class Stack
    {
        public Node Top { get; set; }
        public Stack()
        {
            Top = null;
        }
        public void Push(int value)     // adds a new node with that value to the top of the stack 
        {
            Node newNode = new Node(value);
            newNode.Next = Top;
            Top = newNode;
        }
        public int Pop()    // Removes the node from the top of the stack
        {
            if (Top != null)
            {
                Node temp = Top;
                Top = Top.Next;
                temp.Next = null;
                return temp.Value;
            }
            else
            {
                throw new Exception("The Stack is empty!");
            }

        }
        public Node Peek()  // Returns Value of the node located at the top of the stack
        {
            if (Top != null)
            {
                return Top;
            }
            else
            {
                throw new Exception("The Stack is empty!");
            }
        }
        public bool IsEmpty()  // Check stack is empty or not 
        {
            if (Top == null) return true;
            else return false;
        }
    }
}
