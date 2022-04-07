# Stack And Queue

A stack is a data structure that consists of Nodes. Each Node references the next Node in the stack, 
but does not reference its previous, and follows the concepts of First in Last out. 
A queue follows the same logic as a stack but follows the concepts of First in First out and Last in Last out.


## Challenge
- Create Stack where Push adds node, Pop removes node, peek returns value of top node, 
and IsEmpty lets you know if Stack is empty.
- Create Queue where Enqueue adds node, Dequeue removes node, peek returns value of Front node, 
and IsEmpty lets you know if Queue is empty.


## Approach & Efficiency
#### BigO
- Stack.Push and Queue.Enqueue methods

    Time O(1) / Space O(1)

- Stack.Pop and Queue.Dequeue methods

    Time O(1) / Space O(1)

- Stack.Peek and Queue.Peek methods

    Time O(1) / Space O(1)

## API

#### Stack:
- Push: takes in any value and adds a new Node with that value to the top of the stack
- Pop: removes the Node from the top of the stack and returns its value
- Peek: returns the value of the node located on top of the stack if it exists
- IsEmpty: returns a boolean indicating whether or not the stack is empty
#### Queue:
- Enqueue: takes and value and adds a new node with that value as an argument to the back of the queue
- Dequeue: removes the node from the front of the queue and returns the node's value if it exists
- Peek: returns the value of the node located in the front of the queue if it exists
- IsEmpty: returns a boolean indicating whether or not the queue is empty





