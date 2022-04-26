# Trees
Tree traversals fall into two catagories: depth first, breadth first. 

Depth first can traverse the tree via :
- pre-order(root, left, right) 
- in-order (left, root, right) 
- post-order (left, right, root).

A binary seach can also be used to locate a specific value, In a binary search tree, 
the tree is organized in a manner where all numbers that are smaller than the root are placed to 
the left, and all numbers that are larger than the root are placed to the right. 

The searched value is then compared against the root. 

## Challenge

- Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
- Create a BinaryTree class.
- Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which returns an array of the values, ordered appropriately.
- Create a BinarySearchTree class
- Define a method named add that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
- Define a method named contains that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

## Approach & Efficiency

- BinaryTree Traversal Time: O(n) Space: O(n)

- BinarySearchTree Add Time: O(log n) Space: O(1)

- BinarySearchTree Contains Time: O(log n) Space: O(1)

## API

Binary Tree:

- PreOrder() - Recursively stores the node values of the tree BEFORE traversing to the next and returns them as an array.
- InOrder() - Stores the node values of the tree, starting at the left most leaf and recursively adding back upward, then adding as it goes down the right side, and returns them as an array.
- PostOrder - Stores the node values of the tree, returning the left side of the tree from the bottom up, then the right side from the bottom up, then finally the top root, then returns them as an array.

Binary Search Tree:

- Add(value) - Traverses the nodes of the binary search tree that are directly greater than of less than the given value. When it reaches a leaf, it creates a new node in the position greater than or less than that leaf.
- Contains(value) - Searches the tree for a matching node value, traversing left if the target value is less than the node value, or right if the target value is greater than the node value. Returns true is target is found, false if not.


