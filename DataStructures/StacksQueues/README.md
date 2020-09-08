# Stacks and Queues
## Specifications
Read all of these instructions carefully. Name things exactly as described.
+ Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
+ Create a branch in your repository called stack-and-queue
+ On your branch, create…
  + C#: Create a new class library app named StacksAndQueues.
  + JavaScript: a folder named stacksAndQueues which contains a file called stacks-and-queues.js
  + Python: a folder named stacks_and_queues which contains a file called stacks_and_queues.py
  + Java: a package named stacksandqueues which contains files called Stack.java, Queue.java, and Node.java.
+ Include any language-specific configuration files required for this challenge to become an individual component, module, library, etc.
  + NOTE: You can find an example of this configuration for your course in your class lecture repository.
## Features
+ Create a Node class that has properties for the value stored in the Node, and a pointer to the next node.
+ Create a Stack class that has a top property. It creates an empty Stack when instantiated.
  + This object should be aware of a default empty value assigned to top when the stack is created.
  + Define a method called push which takes any value as an argument and adds a new node with that value to the top of the stack with an O(1) Time performance.
  + Define a method called pop that does not take any argument, removes the node from the top of the stack, and returns the node’s value.
    + Should raise exception when called on empty stack
  + Define a method called peek that does not take an argument and returns the value of the node located on top of the stack, without removing it from the stack.
    + Should raise exception when called on empty stack
  + Define a method called isEmpty that takes no argument, and returns a boolean indicating whether or not the stack is empty.
+ Create a Queue class that has a front property. It creates an empty Queue when instantiated.
  + This object should be aware of a default empty value assigned to front when the queue is created.
  + Define a method called enqueue which takes any value as an argument and adds a new node with that value to the back of the queue with an O(1) Time performance.
  + Define a method called dequeue that does not take any argument, removes the node from the front of the queue, and returns the node’s value.
    + Should raise exception when called on empty queue
  + Define a method called peek that does not take an argument and returns the value of the node located in the front of the queue, without removing it from the queue.
    + Should raise exception when called on empty queue
  + Define a method called isEmpty that takes no argument, and returns a boolean indicating whether or not the queue is empty.
+ Be sure to follow your languages best practices for naming conventions.
+ You have access to the Node class and all the properties on the Linked List class.

## Structure and Testing
Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

Write tests to prove the following functionality:

+ Can successfully push onto a stack
+ Can successfully push multiple values onto a stack
+ Can successfully pop off the stack
+ Can successfully empty a stack after multiple pops
+ Can successfully peek the next item on the stack
+ Can successfully instantiate an empty stack
+ Calling pop or peek on empty stack raises exception
+ Can successfully enqueue into a queue
+ Can successfully enqueue multiple values into a queue
+ Can successfully dequeue out of a queue the expected value
+ Can successfully peek into a queue, seeing the expected value
+ Can successfully empty a queue after multiple dequeues
+ Can successfully instantiate an empty queue
+ Calling dequeue or peek on empty queue raises exception
Ensure your tests are passing before you submit your solution.

# Queue with Stacks
## Feature Tasks
Create a brand new ```PseudoQueue``` class. Do not use an existing Queue. Instead, this PseudoQueue class will implement our standard queue interface (the two methods listed below), but will internally only utilize 2 ```Stack``` objects. Ensure that you create your class with the following methods:

+ ```enqueue(value)``` which inserts value into the PseudoQueue, using a first-in, first-out approach.
+ ```dequeue()``` which extracts a value from the PseudoQueue, using a first-in, first-out approach.
The ```Stack``` instances have only push, pop, and peek methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor.

## Example
```enqueue(value)```
Input |	Args |	Output
------|------|--------------------------------
[10]->[15]->[20] |	5	| [5]->[10]->[15]->[20]
 null	| 5 |	[5]
```dequeue()```
Input	| Output |	Internal State
------|--------|--------------------
[5]->[10]->[15]->[20] |	20 |	[5]->[10]->[15])
[5]->[10]->[15] |	15 |	[5]->[10]
## Requirements
Ensure your complete solution follows the standard requirements.

+ Write unit tests
+ Follow the template for a well-formatted README
+ Submit the assignment following these instructio