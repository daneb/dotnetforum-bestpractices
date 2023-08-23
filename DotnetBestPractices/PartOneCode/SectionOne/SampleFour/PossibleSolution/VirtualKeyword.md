## Virtual

In C#, the `virtual` keyword is used to declare a method in a base class that can be overridden (redefined) in derived classes. When you mark a method as `virtual`, you're indicating that the method's implementation can be replaced by a different implementation in a derived class. This concept is essential for achieving polymorphism and following object-oriented principles like the Liskov Substitution Principle (LSP) and the Open/Closed Principle (OCP).

Here's a breakdown of how the `virtual` keyword works:

1. **Base Class Definition:**

   ```csharp
   public class MyBaseClass
   {
       public virtual void MyVirtualMethod()
       {
           // Default implementation in the base class
       }
   }
   ```

   In this example, the `MyVirtualMethod` is declared as `virtual` in the `MyBaseClass`. This means that derived classes can choose to provide their own implementation of this method.

2. **Derived Class Overrides:**

   ```csharp
   public class MyDerivedClass : MyBaseClass
   {
       public override void MyVirtualMethod()
       {
           // Implementation specific to the derived class
       }
   }
   ```

   In the derived class `MyDerivedClass`, the `MyVirtualMethod` is overridden using the `override` keyword. This allows the derived class to provide its own implementation while still adhering to the method's signature defined in the base class.

3. **Usage:**

   You can use instances of both the base class and the derived class, and the appropriate version of the method will be called based on the actual type of the object:

   ```csharp
   MyBaseClass baseInstance = new MyBaseClass();
   baseInstance.MyVirtualMethod(); // Calls the base class's implementation

   MyBaseClass derivedInstance = new MyDerivedClass();
   derivedInstance.MyVirtualMethod(); // Calls the derived class's overridden implementation
   ```

By using the `virtual` and `override` keywords, you're applying the principles of inheritance and polymorphism in C#. This enables you to create more flexible and extensible code by allowing derived classes to specialize or modify the behavior of methods defined in the base class.