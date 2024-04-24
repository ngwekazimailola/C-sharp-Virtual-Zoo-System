# C# Virtual Zoo Management System

## Overview
This project aims to design and implement a Virtual Zoo Management System in C# to simulate the management of animals in a zoo. The system will allow for the addition, tracking, and interaction with various types of animals, showcasing the principles of inheritance, polymorphism, method overloading, and the use of interfaces.

## Project Objectives
- **Implementing Inheritance:** Design a base class for animals and extend it with specific animal classes, demonstrating hierarchical relationships.
- **Implementing Polymorphism:** Utilize polymorphism to allow for different behaviors among animals, such as speaking or moving, using overridden methods.
- **Using Methods and Method Overloading:** Demonstrate the use of methods to simulate animal behaviors and interactions, implementing method overloading to handle different scenarios or inputs.
- **Using Interfaces:** Define and implement interfaces to standardize certain capabilities or features across different animals, such as feeding or movement.

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
