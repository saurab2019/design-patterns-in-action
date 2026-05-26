# Design Patterns in .NET

This repository contains implementations of various famous **Design Patterns** in **C#/.NET**, inspired by the examples and concepts from the book:

> Head First Design Patterns

The goal of this repository is to deeply understand:
- Object-Oriented Design Principles
- Reusable Software Architecture
- Decoupled System Design
- Maintainable and Scalable Code

Each pattern is implemented with practical examples to demonstrate:
- The problem the pattern solves
- How the pattern works internally
- Real-world use cases



# What are Design Patterns?

Design Patterns are reusable solutions to common software design problems.

They are not ready-made code, but proven architectural approaches that help developers build:
- Flexible systems
- Maintainable code
- Loosely coupled applications
- Scalable software architectures

Design Patterns are widely used in:
- Frameworks
- Enterprise applications
- Game engines
- Distributed systems
- UI frameworks
- Cloud applications



# Patterns Implemented

## 1. Adapter Pattern

### Purpose
Converts one interface into another interface that a client expects.

### Real World Example
A mobile charger adapter converts high-voltage wall power into a format your phone can use.

### Implemented Concepts
- Object Adapter
- Interface conversion
- Legacy system integration



## 2. Command Pattern

### Purpose
Encapsulates a request as an object.

### Real World Example
A restaurant waiter takes your order and sends it to the kitchen without needing to know how the food is prepared.

### Implemented Concepts
- Command objects
- Undo operations
- Decoupling sender and receiver



## 3. Composite Pattern

### Purpose
Treats individual objects and groups of objects uniformly.

### Real World Example
A file system where files and folders are treated similarly.

### Implemented Concepts
- Tree structures
- Recursive composition
- Uniform object handling



## 4. Decorator Pattern

### Purpose
Adds new behavior to objects dynamically without modifying existing code.

### Real World Example
Adding toppings to a pizza or coffee without changing the original item.

### Implemented Concepts
- Runtime behavior extension
- Composition over inheritance
- Flexible feature additions



## 5. Factory Method Pattern

### Purpose
Defines an interface for object creation while letting subclasses decide which object to create.

### Real World Example
A logistics company creating different transport objects like Truck, Ship, or Air Cargo depending on delivery type.

### Implemented Concepts
- Object creation abstraction
- Loose coupling
- Polymorphic instantiation



## 6. Observer Pattern

### Purpose
Defines a one-to-many dependency between objects so that when one object changes state, all dependents are notified automatically.

### Real World Example
YouTube subscribers receiving notifications when a creator uploads a new video.

### Implemented Concepts
- Event-driven architecture
- Publish-subscribe model
- Reactive communication



## 7. Iterator Pattern

### Purpose
Provides a way to access elements of a collection sequentially without exposing its internal structure.

### Real World Example
Scrolling through songs in a music playlist.

### Implemented Concepts
- Sequential traversal
- Collection abstraction
- Encapsulated iteration logic



## 8. Proxy Pattern

The Proxy Pattern provides a placeholder or surrogate object to control access to another object.

This repository includes multiple types of proxies.



### 8.1 Remote Proxy

#### Purpose
Represents an object located on a remote server.

#### Real World Example
A local application communicating with a remote cloud service.

#### Implemented Concepts
- Remote communication abstraction
- Distributed systems design
- Network transparency



### 8.2 Virtual Proxy

#### Purpose
Controls access to expensive objects by creating them only when needed.

#### Real World Example
Lazy loading high-resolution images on websites.

#### Implemented Concepts
- Lazy initialization
- Performance optimization
- Resource management



### 8.3 Protection Proxy

#### Purpose
Controls access to an object based on permissions.

#### Real World Example
Admin panels where only authorized users can modify settings.

#### Implemented Concepts
- Access control
- Authorization
- Security abstraction



## 9. Singleton Pattern

### Purpose
Ensures that only one instance of a class exists.

### Real World Example
Application-wide configuration manager or logging service.

### Implemented Concepts
- Controlled instantiation
- Global shared state
- Thread-safe singleton concepts



## 10. State Pattern

### Purpose
Allows an object to alter its behavior when its internal state changes.

### Real World Example
A vending machine behaving differently depending on whether it has money inserted or not.

### Implemented Concepts
- State-driven behavior
- Eliminating large conditionals
- Dynamic behavior switching

## 11. Template Method Pattern

### Purpose
Defines the skeleton of an algorithm while allowing subclasses to customize specific steps.

### Real World Example
Making beverages where boiling water is common, but tea and coffee preparation differ.

### Implemented Concepts
- Algorithm standardization
- Hook methods
- Code reuse through inheritance

# Running and Testing Patterns

Each design pattern folder contains a dedicated `*TestDrive.cs` file used to test and experiment with that specific pattern implementation.

Example:

```csharp
namespace DesignPatterns.IteratorPattern
{
    public class IteratorPatternTestDrive : TestDrive
    {
        public static void test()
        {
            /* Write the code here to test the implementation of the Iterator Pattern */

            Console.WriteLine("Iterator Pattern Test Drive");
        }
    }
}
```

These test drive classes act as small entry points for:
- Testing pattern behavior
- Understanding object interactions
- Experimenting with different implementations
- Learning how the pattern works internally

To test a pattern:
1. Open the corresponding `*TestDrive.cs` file
2. Write or modify the test code
3. Call the `test()` method from `Program.cs`

Example:

```csharp
IteratorPatternTestDrive.test();
```

This structure keeps:
- Pattern implementation separated
- Testing clean and modular
- Code easy to navigate and extend

# Technologies Used

- C#
- .NET
- Object-Oriented Programming
- SOLID Principles



# Learning Goals

This repository was created to:
- Practice software design principles
- Understand low-level architecture
- Improve object-oriented thinking
- Learn enterprise-level coding practices
- Explore reusable software patterns



# Future Improvements

Potential future additions:
- Strategy Pattern
- Facade Pattern
- Builder Pattern
- Flyweight Pattern
- Mediator Pattern
- Dependency Injection examples
- Multithreaded pattern implementations



# References

- Head First Design Patterns
- Gang of Four (GoF) Design Patterns
- Microsoft .NET Documentation



# Author

Saurabh Garg

Passionate about:
- Software Engineering
- System Design
- Backend Development
- Architecture Patterns
- Scalable Applications

