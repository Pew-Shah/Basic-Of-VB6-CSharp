# Arrays :

## C# :

### Syntax :

### **Single-Dimensional Arrays**

**Declaration:**
```csharp
type[] arrayName;
```

**Initialization:**
```csharp
arrayName = new type[size];
```

**Declaration and Initialization:**
```csharp
type[] arrayName = new type[size];
```

**Initialization with Values:**
```csharp
type[] arrayName = { value1, value2, value3 };
```

### **Multi-Dimensional Arrays**

**Two-Dimensional Array Declaration and Initialization:**
```csharp
type[,] arrayName = new type[rows, columns];
```

**Two-Dimensional Array with Values:**
```csharp
type[,] arrayName = {
    { value11, value12 },
    { value21, value22 }
};
```

### **Jagged Arrays**

**Declaration:**
```csharp
type[][] arrayName;
```

**Initialization:**
```csharp
arrayName = new type[rowCount][];
```

**Initialization of Inner Arrays:**
```csharp
arrayName[0] = new type[columnCount];
arrayName[1] = new type[anotherColumnCount];
```

**Declaration and Initialization:**
```csharp
type[][] arrayName = {
    new type[] { value1, value2 },
    new type[] { value3, value4, value5 }
};
```

### **Accessing Elements**

**Single-Dimensional Array:**
```csharp
type element = arrayName[index];
```

**Two-Dimensional Array:**
```csharp
type element = arrayName[rowIndex, columnIndex];
```

**Three-Dimensional Array:**
```csharp
type element = arrayName[depthIndex, rowIndex, columnIndex];
```

**Jagged Array:**
```csharp
type element = arrayName[rowIndex][columnIndex];
```

### **Iterating Over Arrays**

**Single-Dimensional Array:**
```csharp
foreach (type item in arrayName)
{
    // Use item
}
```

**Two-Dimensional Array:**
```csharp
for (int i = 0; i < arrayName.GetLength(0); i++)
{
    for (int j = 0; j < arrayName.GetLength(1); j++)
    {
        // Use arrayName[i, j]
    }
}
```

**Jagged Array:**
```csharp
foreach (type[] row in arrayName)
{
    foreach (type item in row)
    {
        // Use item
    }
}
```
.
---
## VB6 :


### **Single-Dimensional Arrays**

**Declaration:**
```vb
Dim arrayName(size) As type
```

**Dynamic Array Declaration:**
```vb
Dim arrayName() As type
```

**Dynamic Array Initialization:**
```vb
ReDim arrayName(size)
```

**Initializing with Values:**
```vb
Dim arrayName() As type
arrayName = Array(value1, value2, value3)
```

### **Multi-Dimensional Arrays**

**Two-Dimensional Array Declaration:**
```vb
Dim arrayName(rowCount, columnCount) As type
```

**Three-Dimensional Array Declaration:**
```vb
Dim arrayName(depth, rowCount, columnCount) As type
```

### **Jagged Arrays (Arrays of Arrays)**

**Declaration of Arrays of Arrays:**
```vb
Dim jaggedArray() As Variant
ReDim jaggedArray(size)
ReDim jaggedArray(index)(subIndex) As type
```

### **Accessing Elements**

**Single-Dimensional Array:**
```vb
arrayName(index) = value
```

**Two-Dimensional Array:**
```vb
arrayName(rowIndex, columnIndex) = value
```

**Jagged Array (Arrays of Arrays):**
```vb
jaggedArray(index1)(index2) = value
```

