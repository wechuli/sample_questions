# Time And Space Complexity


## Time Complexity

        O(N)

### Proof

The method begins by creating a Dictionary data structures to store values of nodes it has already seen (when its starts walking through the list). The algorithms only goes through the linked list once. On each node, it checks to see if this value is already on the dictionary, if it is not, it adds it there with a value of 1, the key being the node value. If the node value already exists in the dictionary as a key, it confirms whether this value is 2 or more, if it is, the current node is deleted(through a method on the linked list itself), if the value is 1, the node is skipped and moves to the next node, accessing and changing values from the dictionary are all `O(1)` operations, hence the alogirthm big-Oh is `O(N)` owing to the fact that it has to walk through all the nodes in the linked list.