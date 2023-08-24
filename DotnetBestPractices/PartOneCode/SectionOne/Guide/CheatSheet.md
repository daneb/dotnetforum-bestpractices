## Cheat Sheet

### Sample One (SRP)
1. Which one of the rules of SOLID is this?
2. So what can we do better here?

### Sample Two (DI)
1. Which one of the rules of SOLID is this?
2. So we have a switch that depends on a light-bulb? 

### Sample Three (OC)
1. Which one of the rules of SOLID is this?
2. We are building a game, and we need to calculate areas of shapes and so we start with a Rectangle?

### Sample  Four (LSP)
1. Which one of the rules of SOLID is this?
2. Whats wrong with Ostrich in this situation?
3. What is it causing? 
4. Is this unexpected behaviour ok?

### Sample Five (IS)
1. Which one of the rules of SOLID is this?
2. What should we do here? 

### Definition

#### Basic
**1. Single Responsibility Principle (SRP):**
Imagine you have a toolbox. Each tool has one specific job it's good at. Similarly, in your code, each class or module should have just one job or responsibility. If a class does too many things, it becomes hard to understand and modify. So, keep things focused and single-purpose.

**2. Open/Closed Principle (OCP):**
Think of your code as a book that you can read, but you can't change the words. The Open/Closed Principle says your code should be like that – open for extension but closed for modification. This means you should be able to add new features or behaviors without changing existing code. You achieve this by using things like inheritance and interfaces.

**3. Liskov Substitution Principle (LSP):**
Imagine you have a toy car. If someone gives you a remote control, you expect it to work with the toy car, right? Similarly, in your code, if you have a class (let's say a subclass) that inherits from another class (a superclass), you should be able to use objects of the subclass wherever you use objects of the superclass, without causing problems.

**4. Interface Segregation Principle (ISP):**
Think of interfaces as contracts that your classes promise to fulfill. But imagine if one contract was super long and had things you don't really need. That would be a pain, right? The Interface Segregation Principle says you should have small, specific interfaces that cater to the needs of the classes that use them, so you don't force unnecessary stuff on them.

**5. Dependency Inversion Principle (DIP):**
Imagine you're building a LEGO tower, and each brick fits into another. Now, what if you could replace a red brick with a blue one, and everything still worked fine? That's the idea behind the Dependency Inversion Principle. High-level modules (the big picture) should not depend on low-level modules (the details). Instead, both should depend on abstractions (like interfaces).

#### TextBook
1. **Single Responsibility Principle (SRP):**
   A class should have only one reason to change, meaning it should have a single responsibility. It should encapsulate only one piece of functionality or concept.

2. **Open/Closed Principle (OCP):**
   Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. You should be able to add new features or behaviors without changing existing code.

3. **Liskov Substitution Principle (LSP):**
   Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. Subclasses should behave in such a way that they don't break the behavior expected from their superclass.

4. **Interface Segregation Principle (ISP):**
   Clients (classes or modules that use your code) should not be forced to depend on interfaces they do not use. This principle suggests that you should have small, focused interfaces that cater to the specific needs of clients.

5. **Dependency Inversion Principle (DIP):**
   High-level modules should not depend on low-level modules; both should depend on abstractions. Abstractions (like interfaces or abstract classes) should not depend on details; details should depend on abstractions. This principle promotes loose coupling and easier maintainability.

Remember that these principles are guidelines to help you design better, more maintainable software. They can be applied differently depending on the context and specific needs of your project.

### Difference between Inversion and DI?
