# Multi Bracket Validation
A challenge to determine if a string containing brackets is "balanced" 

# Challenge Summary

Your function should take a string as its only argument, and should return a boolean 
representing whether or not the brackets in the string are balanced. 

There are 3 types of brackets:

- Round Brackets : ()
- Square Brackets : []
- Curly Brackets : {}

## Whiteboard Process
![Whiteboard](Assest/Whiteboard.png)
## Approach & Efficiency
Time: O(n) since it iterates the length of the string.

Space: O(n) since a new Stack was created to store brackets.