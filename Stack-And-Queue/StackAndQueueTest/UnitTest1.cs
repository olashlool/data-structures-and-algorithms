using System;
using Xunit;
using stack_and_queue;
namespace StackAndQueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestPushToStack()  // Test push onto a stack
        {
            Stack stack = new Stack();
            stack.Push(5);
            Assert.Equal(5, stack.Top.Value);
        }
        [Fact]
        public void TestMultiPushToStack()  //Test push multiple values onto a stack
        {
            Stack stack = new Stack();
            stack.Push(15);
            stack.Push(2);
            stack.Push(22);
            Assert.Equal(22, stack.Top.Value);
        }
        [Fact]
        public void TestPopFromStack()  // Test pop off the stack
        {
            Stack stack = new Stack();
            stack.Push(5);
            Assert.Equal(5, stack.Pop());
        }

         [Fact]
         public void TestEmptyStack()  // Test empty a stack after multiple pops
        {
             Stack stack = new Stack();
             stack.Push(5);
             stack.Push(8);
             stack.Push(2);
             stack.Pop();
             stack.Pop();
             stack.Pop();
             Exception e = Assert.Throws<System.Exception>(() => stack.Peek());
             Assert.Equal("The Stack is empty!", e.Message);
         }
        [Fact]
        public void TestPeekAtStack()        // peek the next item on the stack
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1, stack.Peek().Value);
        }
        [Fact]
        public void TestEmptyStackCreation()  // Test instantiate an empty stack
        {
            Stack stack = new Stack();
            Assert.Null(stack.Top);
        }
        [Fact]
        public void PeekEmptyStack()  // peek on empty stack raises exception
        {
            Stack stack = new Stack();       
            Exception e = Assert.Throws<System.Exception>(() => stack.Peek());
            Assert.Equal("The Stack is empty!", e.Message);
        }

        [Fact]
        public void TestEnqueueQueue()  //  Test enqueue into a queue
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Front.Value);
        }

        [Fact]
        public void TestMultiEnqueue() // Test enqueue multiple values into a queue
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            Assert.Equal(5, queue.Front.Value);
        }
        [Fact]
        public void TestDequeue()  // Test dequeue
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            Node test = queue.Dequeue();
            Assert.Equal(5, test.Value);
        }
        [Fact]
        public void TestPeek()         // Test peek into a queue
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Peek().Value);
        }
        [Fact]
        public void TestEmptyQueue()  // Test empty a queue after multiple Dequeue
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(8);
            queue.Enqueue(2);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            Exception e = Assert.Throws<System.Exception>(() => queue.Peek());
            Assert.Equal("The Queue is empty!", e.Message);
        }

        [Fact]
        public void TestEmptyQueueCreation()  // // Test instantiate an empty queue
        {
            Queue queue = new Queue();
            Assert.Null(queue.Front);
        }
        [Fact]
        public void PeekEmptyQueue()  // peek on empty queue raises exception
        {
            Queue queue = new Queue();
            Exception e = Assert.Throws<System.Exception>(() => queue.Peek());
            Assert.Equal("The Queue is empty!", e.Message);
        }
    }
}
