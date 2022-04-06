# Singly Linked List

A linked list is a linear data structure, in which the elements are not stored at contiguous memory locations.
A linked list consists of nodes where each node contains a data field and a reference to the next node in the list.

# Description
This program is a simple test of how Linked Lists work and operate. It as methods to add linked lists, 
before and after nodes. Also in the front of the link list. It can locate a node and add a node. 
Linked Lists seem to be useful when you're needing to have a conglomerate of information that changes in size. 
Compared to arrays, you can add a node at the front of the LinkedList so the Big O for Time is much much faster
than adding it to the end of an array without affecting the rest of the array.

Write a method for the Linked List class which takes a number k, Return the node’s value that is 
k from the end of the linked list. 

Create a ZipList method that will take in 2 lists and merge them via alternating nodes from each list

# Challenge Summary
- Create a linked list and node class 
- Create methods to 
  - Insert 
  - Includes 
  - ToString
  - Append
  - InsertBefor
  - InsertAfter
  - KthFromEnd
  - zipLists

## Whiteboard Process
- [Append - Whiteboard](assest/Append.png)
- [InsertBefore - Whiteboard](assest/InsertBefore.png)
- [InsertAfter - Whiteboard](assest/InsertAfter.png)
- [KthFromEnd - Whiteboard](assest/KthFromEnd.png)
- [zipLists - Whiteboard](assest/zipLists.png)


## Approach & Efficiency
##### Includes
- Big O Time = O(n)
- Big O Space = O(n)

##### Insert
- Big O Time = O(1) 
- Big O Space = O(n)
##### Append
- Big O Time = O(n) 
- Big O Space = O(1)

##### InsertBefore
- Big O Time = O(n) 
- Big O Space = O(1)

##### InsertAfter
- Big O Time = O(n) 
- Big O Space = O(1)

##### KthFromEnd
- Big O Time = O(n) 
- Big O Space = O(1)

##### zipLists
- Big O Time = O(n) 
- Big O Space = O(1)
## API
- Insert method :

> Arguments: data Adds a new node with value to the head of the list with an O(1) Time performance.

- Includes method :

> Arguments: data search in the linked List with an o(n) Time performance. 

- ToString method :

> its a method to print the collecation for all the element inside the linked list.

- Append Method :
> which adds a new node with the given value to the end of the list


- InsertBefore Method :
> which add a new node with the given newValue immediately before the value node

- InsertAfter Method :
> which add a new node with the given newValue immediately after the value node

- KthFromEnd Method
>  method for the Linked List class which takes a number k, Return the node’s value that is 
k from the end of the linked list. 

- zipLists
> method for the Linked List class which accepts two linked lists. 
Return a single linked list where the values have been merged, like a zipper.​



