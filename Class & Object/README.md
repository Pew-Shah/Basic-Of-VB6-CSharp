# Class & Object :

## C# :



### Defining a Class

```csharp
public class ClassName
{
    // Fields
    public int fieldName;

    // Properties
    public string PropertyName { get; set; }

    // Constructor
    public ClassName()
    {
        // Initialization code
    }

    // Method
    public void MethodName()
    {
        // Method code
    }
}
```

### Creating an Object

```csharp
ClassName obj = new ClassName();
```

### Key Components

1. **Fields**: Variables declared inside a class but outside any method.
   ```csharp
   public int id;
   ```

2. **Properties**: Special methods to get or set values of fields.
   ```csharp
   public string Name { get; set; }
   ```

3. **Constructors**: Special methods called when an object is instantiated.
   ```csharp
   public ClassName()
   {
       // Initialization code
   }
   ```

4. **Methods**: Functions defined inside a class to perform operations.
   ```csharp
   public void MethodName()
   {
       // Method code
   }
   ```

5. **Objects**: Instances of a class created using the `new` keyword.
   ```csharp
   ClassName obj = new ClassName();
   ```

### Key Components

1. **Fields**: Variables declared within the class.
2. **Properties**: Methods for getting and setting field values.
3. **Constructors**: Special methods used for initializing objects.
4. **Methods**: Functions within a class for performing operations.
5. **Objects**: Instances of a class created using `new`.


In C#, there are several types of classes that you can use, each serving different purposes. Here’s an overview of the main types:

### 1. **Regular Classes**

The most common type of class. They are used to define objects and encapsulate data and behavior.

```csharp
public class RegularClass
{
    // Members: fields, properties, methods, etc.
}
```

### 2. **Abstract Classes**

An abstract class cannot be instantiated directly. It is used as a base class for other classes. It can include abstract methods that must be implemented by derived classes.

```csharp
public abstract class AbstractClass
{
    public abstract void AbstractMethod();

    public void RegularMethod()
    {
        // Implementation
    }
}
```

### 3. **Sealed Classes**

A sealed class cannot be inherited. Use `sealed` to prevent further derivation.

```csharp
public sealed class SealedClass
{
    // Members
}
```

### 4. **Static Classes**

A static class cannot be instantiated and can only contain static members. It is used to group related utility methods.

```csharp
public static class StaticClass
{
    public static void StaticMethod()
    {
        // Implementation
    }
}
```

### 5. **Partial Classes**

Partial classes allow you to split the definition of a class across multiple files. This is useful for managing large classes or when working with auto-generated code.

```csharp
// File1.cs
public partial class PartialClass
{
    // Members
}

// File2.cs
public partial class PartialClass
{
    // Additional members
}
```

### Summary

- **Regular Classes**: Basic class type.
- **Abstract Classes**: Cannot be instantiated; meant to be inherited.
- **Sealed Classes**: Cannot be inherited.
- **Static Classes**: Cannot be instantiated; only contain static members.
- **Partial Classes**: Split across multiple files.

