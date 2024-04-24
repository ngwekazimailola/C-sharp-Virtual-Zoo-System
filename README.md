# C# Virtual Zoo Management System

## Description
The Virtual Zoo Management System in C# is a software application designed to oversee the management of animals within a virtual zoo environment. This system enables users to add, track, and interact with different types of animals, emphasizing concepts such as inheritance, polymorphism, method overloading, and interface implementation. Through the use of classes and interfaces, the system facilitates the organization and simulation of various animal behaviors and characteristics.

## Project Tasks

### Task 1: Class Hierarchy and Inheritance
- Design a base class named `Animal` with common properties (e.g., Name, Age) and methods (e.g., Eat, Sleep).
- Extend the `Animal` class to create specific animal classes (e.g., Lion, Parrot, Turtle), overriding base class methods to provide specific behaviors.

### Task 2: Polymorphism and Method Overriding
- Implement method overriding in the derived classes to exhibit unique behaviors, such as different sounds for the Speak method.
- Demonstrate polymorphic behavior by interacting with collections of the base class type (`Animal`) containing various derived class instances.

### Task 3: Methods and Method Overloading
- Implement various methods within animal classes to simulate behaviors (e.g., Move, Speak).
- Overload methods to provide different implementations based on parameters, such as accepting different types of food for the Eat method.

### Task 4: Implementing Interfaces
- Define interfaces such as `IFeedable` with a method `Feed` and `IMovable` with a method `Move`.
- Implement these interfaces in applicable animal classes, ensuring that the behaviors are consistent with the interface definitions.

## Project Structure
The project consists of the following files:
- **Program.cs:** Contains the main entry point of the application and user interaction logic.
- **Animal.cs:** Defines the base `Animal` class, specific animal classes, and interfaces for feeding and movement.
- **VirtualZoo.cs:** Implements the `VirtualZoo` class responsible for managing animals within the virtual zoo.
