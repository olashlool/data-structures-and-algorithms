# Hashtables
Hashtables are a data structure that utilize key value pairs. This means every Node or Bucket has both a key, and a value. 
The basic idea of a hashtable is the ability to store the key into this data structure, and quickly retrieve the value. 
This is done through what we call a hash. A hash is the ability to encode the key that will eventually map to a specific 
location in the data structure that we can look at directly to retrieve the value. Since we are able to hash our key and 
determine the exact location where our value is stored.

## Challenge
Implement a Hashtable with the following methods:

- `Set` : takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
- `Get` : takes in the key and returns the value from the table.
- `Contains` : takes in the key and returns a boolean, indicating if the key exists in the table already.
- `Hash` : takes in an arbitrary key and returns an index in the collection.
- `Keys` : Returns Collection of keys


## Approach & Efficiency

| Method | Big O Time | Big O Space |
| :-----  | :-------: | :-------: |
| Set |  O(1) | O(1) |
| Get |  O(n) | O(1) |
| Hash |  O(1) | O(1) |
| Contains |  O(1) | O(1) |



