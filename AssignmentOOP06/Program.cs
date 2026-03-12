#region Qusetion01:
// Q1: What is abstraction in OOP?
//     How is it different from encapsulation?
//     Give a real-world example (not from the session) that shows the difference between the two.

// Answer: Abstraction is the concept of showing only the essential features of an object while hiding the complex implementation details.
//         It focuses on what an object does, not how it does it.
//         Encapsulation, on the other hand, is the concept of bundling data and methods that operate on that data within a single unit (class) and restricting access to some of the object's components.
//         It focuses on how an object is implemented and protects the internal state of the object from outside interference.
/*
          Real-World Example (ATM Machine)
         
          * Abstraction:
          When you use an ATM machine, you only see options like:
         - Withdraw money
         - Check balance
         - Deposit money
          You don’t see how the bank processes the transaction internally.
          The complex system is hidden. This is abstraction.
          
          * Encapsulation
          Inside the bank system, your account balance is stored privately.
          You cannot directly change it. Instead, you must use operations like:
          - Withdraw
          - Deposit
          These operations control how the balance changes.
          This is encapsulation.
 */

#endregion

#region Qusetion02:
// Q2: What is the difference between an abstract class and an interface? Give at least four differences. When would you choose one over the other?

// Answer: An abstract class cannot be instantiated and can contain both abstract and concrete methods, allowing code reuse.
//         An interface, acting as a strict contract, primarily defines abstract method signatures that implementing classes must define, supporting multiple inheritance.
//         An abstract class can have fields and constructors, while an interface cannot have fields and only allows for default implementations in C# 8.0 and later.
//
//       An abstract class is used when there is a clear hierarchical relationship and shared code among classes,
//         while an interface is ideal for defining capabilities that can be implemented by unrelated classes.
#endregion