# Loops:

## C# :


| **Loop Type**       | **Description**                                           |
|---------------------|-----------------------------------------------------------|
| **`for` Loop**      | Repeats a block of code a specific number of times.      |
| **`while` Loop**    | Repeats a block of code as long as the condition is true. |
| **`do-while` Loop** | Repeats a block of code at least once and then as long as the condition is true. |
| **`foreach` Loop**  | Iterates over each element in a collection (e.g., arrays, lists). |


### Syntax :

Certainly! Here’s the syntax for each type of loop in C# with numbered examples:

1. **`for` Loop:**
   ```csharp
   for (initialization; condition; iteration)
   {
       // Code to execute
   }
   ```

2. **Nested `for` Loop:**
   ```csharp
   for (initialization1; condition1; iteration1)
   {
       for (initialization2; condition2; iteration2)
       {
           // Code to execute
       }
   }
   ```

3. **`while` Loop:**
   ```csharp
   while (condition)
   {
       // Code to execute
   }
   ```

4. **`do-while` Loop:**
   ```csharp
   do
   {
       // Code to execute
   } while (condition);
   ```

5. **`foreach` Loop:**
   ```csharp
   foreach (type variable in collection)
   {
       // Code to execute
   }
   ```

### C# Break & Continue :

In C#, `break` and `continue` are control statements used to alter the flow of loops:

**`break`**
Purpose: Exits the nearest enclosing loop (`for`, `while`, `do-while`, or `foreach`) immediately, skipping any remaining iterations.

**`continue`**
Purpose: Skips the remaining code inside the loop for the current iteration and proceeds to the next iteration of the loop.
---
---
## VB6 :


| **Loop Type**       | **Description**                                               |
|---------------------|---------------------------------------------------------------|
| **`For...Next` Loop** | Repeats a block of code a specific number of times.          |
| **Nested `For` Loop** | A `For` loop inside another `For` loop, useful for multidimensional structures. |
| **`While...Wend` Loop** | Repeats a block of code as long as a condition is true.      |
| **`Do While...Loop`** | Repeats a block of code as long as a condition is true, but ensures the code is executed at least once. |
| **`Do Until...Loop`** | Repeats a block of code until a condition becomes true.       |
| **`For Each` Loop** | Iterates over each element in a collection (e.g., arrays, collections). |

### Syntax :

1. **`For...Next` Loop:**
   ```vb
   For counter = start To end [Step step]
       ' Code
   Next counter
   ```

2. **Nested `For` Loop:**
   ```vb
   For counter1 = start1 To end1
       For counter2 = start2 To end2
           ' Code
       Next counter2
   Next counter1
   ```

3. **`While...Wend` Loop:**
   ```vb
   While condition
       ' Code
   Wend
   ```

4. **`Do While...Loop` Loop:**
   ```vb
   Do While condition
       ' Code
   Loop
   ```

5. **`Do Until...Loop` Loop:**
   ```vb
   Do Until condition
       ' Code
   Loop
   ```

6. **`For Each` Loop:**
   ```vb
   For Each element In collection
       ' Code
   Next element
   ```

#### Do Loop :


| **Do While** Loop                    | **Do...Loop While** Loop             |
|--------------------------------------|--------------------------------------|
| `Do While condition` <br> `    ' Block of one or more VB statements` <br> `Loop` | `Do` <br> `    ' Block of one or more VB statements` <br> `Loop While condition` |

| **Do Until** Loop                    | **Do...Loop Until** Loop             |
|--------------------------------------|--------------------------------------|
| `Do Until condition` <br> `    ' Block of one or more VB statements` <br> `Loop` | `Do` <br> `    ' Block of one or more VB statements` <br> `Loop Until condition` |

### Exiting the Loop :

1. **`Exit For`**
   - **Purpose:** Exits the nearest enclosing `For` loop immediately.
   - **Syntax:**
     ```vb
     Exit For
     ```

2. **`Exit Do`**
   - **Purpose:** Exits the nearest enclosing `Do` loop immediately.
   - **Syntax:**
     ```vb
     Exit Do
     ```