# Functions

## C# :


### 1. **Method Definition**

```csharp
returnType MethodName(parameterType parameterName, ...)
{
    // Method body
    // Optional: return value of returnType
}
```

### 2. **Default Parameters**

```csharp
returnType MethodName(parameterType parameterName = defaultValue, ...)
{
    // Method body
}
```

### 3. **Method Overloading**

```csharp
returnType MethodName(parameterType1 parameterName1, ...)
{
    // Method body
}

// Overloaded method with different parameters
returnType MethodName(differentParameterType2 parameterName2, ...)
{
    // Method body
}
```


### **C# Functions**

1. **Return Type**: Functions must declare a return type; use `void` for functions that do not return a value.
2. **Access Modifiers**: Functions can be modified with access modifiers such as `public`, `private`, `protected`, and `internal`.
3. **Method Overloading**: Supports multiple functions with the same name but different parameter lists.
4. **Method Parameters**: Supports `ref`, `out`, and `in` parameters for different types of argument passing.
5. **Named Arguments**: Allows passing arguments by name to improve clarity.
6. **Lambda Expressions**: Supports lambda expressions for inline function definitions.
                           Syntax: parameters => expression or parameters => { statements }
7. **Anonymous Methods**: Allows defining methods inline, often used in event handling.
.
---
---


## VB6:


### 1. **Sub Procedure**

```vb
Public Sub ProcedureName(parameterName As ParameterType, ...)
    ' Procedure body
End Sub
```

### 2. **Function Procedure**

```vb
Public Function FunctionName(parameterName As ParameterType, ...) As ReturnType
    ' Function body
    FunctionName = returnValue
End Function
```

### 3. **Default Parameters**

VB6 does not support default parameter values natively. Use the `Optional` keyword:

```vb
Public Sub ProcedureName(Optional parameterName As ParameterType = defaultValue)
    ' Procedure body
End Sub
```

### 4. **Overloading**

VB6 does not support method overloading. Use different names for different methods:

```vb
Public Sub MethodName1(parameterName As ParameterType)
    ' Method body
End Sub

Public Sub MethodName2(parameterName As DifferentParameterType)
    ' Method body
End Sub
```

### **VB6 Functions**

1. **Return Type**: Functions must declare a return type; use `Sub` for procedures that do not return a value.
2. **Access Modifiers**: Functions can be `Public`, `Private`, `Protected`, or `Friend`.
3. **Function Overloading**: Does not support overloading; each function must have a unique name.
4. **Optional Parameters**: Supports optional parameters with default values using the `Optional` keyword.
5. **ByRef and ByVal**: Parameters can be passed by reference (`ByRef`) or by value (`ByVal`).
6. **No Lambda Expressions**: Does not support lambda expressions; all methods must be defined in the traditional manner.
7. **Event Handling**: Functions often handle events and must follow specific event procedure signatures.