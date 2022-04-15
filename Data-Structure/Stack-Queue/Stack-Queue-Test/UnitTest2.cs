using System;
using Xunit;
using Stack_Queue;
namespace Stack_Queue_Test
{
    public class UnitTest2
    {
        [Fact]
        public void EnqueueNodesPushToTop()
        {
            PseudoQueue q = new PseudoQueue();
            q.Enqueue(0);
            Assert.Equal(0, q.Stack1.Top.Value);
        }

        [Fact]
        public void TwoEnqueueNodesPushToTop()
        {
            PseudoQueue q = new PseudoQueue();

            q.Enqueue(0);
            q.Enqueue(1);
            Assert.Equal(1, q.Stack1.Top.Value);
        }

        [Fact]
        public void ThreeEnqueueNodesPushToTop()
        {
            PseudoQueue q = new PseudoQueue();

            q.Enqueue(0);
            q.Enqueue(1);
            q.Enqueue(2);
            Assert.Equal(2, q.Stack1.Top.Value);
        }

        [Fact]
        public void DequeueReturnsFrontNode()
        {
            PseudoQueue q = new PseudoQueue();
            q.Enqueue(22); // front <---result
            q.Enqueue(33);
            q.Enqueue(44);
            q.Enqueue(55); // rear

            Assert.Equal(22, q.Dequeue());
        }

        [Fact]
        public void DoubleDequeue()
        {
            PseudoQueue q = new PseudoQueue();
            q.Enqueue(22); // front
            q.Enqueue(33); // <----result
            q.Enqueue(44);
            q.Enqueue(55); // rear

            q.Dequeue();
            Assert.Equal(33, q.Dequeue());
        }

        [Fact]
        public void DequeueSingleNodeStackToNull()
        {
            PseudoQueue q = new PseudoQueue();

            q.Enqueue(9999);

            Assert.Equal(9999, q.Dequeue());
            Assert.Null(q.Stack1.Top);
        }
    }
}
