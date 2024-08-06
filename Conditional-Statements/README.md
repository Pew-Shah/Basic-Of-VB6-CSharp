# Conditional Statements

## C#

| **Sr.No.** | **Statements**             | **Description**                                                                                          |
|------------|----------------------------|----------------------------------------------------------------------------------------------------------|
| 1          | `if` Statement             | An `if` statement consists of a boolean expression followed by one or more statements.                   |
| 2          | `if...else` Statement      | An `if` statement can be followed by an optional `else` statement, which executes when the boolean expression is false. |
| 3          | `else if` Statement        | Used in conjunction with `if` and `else` to test additional conditions if the previous conditions are false. |
| 4          | Nested `if` Statements     | You can use one `if` or `else if` statement inside another `if` or `else if` statement(s).               |
| 5          | `switch` Statement         | A `switch` statement allows a variable to be tested for equality against a list of values.               |
| 6          | Nested `switch` Statements | You can use one `switch` statement inside another `switch` statement(s).                                |

### Syntax:

1. **`if` Statement**

    ```csharp
    if (condition)
    {
        // Code to execute if condition is true
    }
    ```

2. **`if...else` Statement**

    ```csharp
    if (condition)
    {
        // Code to execute if condition is true
    }
    else
    {
        // Code to execute if condition is false
    }
    ```

3. **`else if` Statement**

    ```csharp
    if (condition1)
    {
        // Code to execute if condition1 is true
    }
    else if (condition2)
    {
        // Code to execute if condition1 is false and condition2 is true
    }
    else
    {
        // Code to execute if none of the conditions are true
    }
    ```

4. **Nested `if` Statements**

    ```csharp
    if (condition1)
    {
        if (condition2)
        {
            // Code to execute if both condition1 and condition2 are true
        }
        else
        {
            // Code to execute if condition1 is true but condition2 is false
        }
    }
    else
    {
        // Code to execute if condition1 is false
    }
    ```

5. **`switch` Statement**

    ```csharp
    switch (variable)
    {
        case value1:
            // Code to execute if variable equals value1
            break;
        case value2:
            // Code to execute if variable equals value2
            break;
        default:
            // Code to execute if variable does not match any case
            break;
    }
    ```

6. **Nested `switch` Statements**

    ```csharp
    switch (variable1)
    {
        case value1:
            switch (variable2)
            {
                case valueA:
                    // Code to execute if variable1 equals value1 and variable2 equals valueA
                    break;
                default:
                    // Code to execute if variable2 does not match any case
                    break;
            }
            break;
        default:
            // Code to execute if variable1 does not match any case
            break;
    }
    ```

---

## VB6

| **Sr.No.** | **Statements**                   | **Description**                                                                                          |
|------------|----------------------------------|----------------------------------------------------------------------------------------------------------|
| 1          | `If` Statement                   | An `If` statement consists of a boolean expression followed by one or more statements.                   |
| 2          | `If...Then...Else` Statement     | An `If` statement can be followed by an optional `Else` statement, which executes when the boolean expression is false. |
| 3          | `If...Then...ElseIf...Else` Statement | Used in conjunction with `If` and `Else` to test additional conditions if the previous conditions are false. |
| 4          | Nested `If` Statements           | You can use one `If` or `ElseIf` statement inside another `If` or `ElseIf` statement(s).                 |
| 5          | `Select Case` Statement          | A `Select Case` statement allows a variable to be tested for equality against a list of values.          |
| 6          | Nested `Select Case` Statements  | You can use one `Select Case` statement inside another `Select Case` statement(s).                       |

### Syntax:

1. **`If` Statement:**

    ```vb
    If condition Then
        ' one or more statements
    End If
    ```

2. **`If...Then...Else` Statement:**

    ```vb
    If condition Then
        ' one or more statements
    Else
        ' one or more statements
    End If
    ```

3. **`If...Then...ElseIf...Else` Statement:**

    ```vb
    If condition1 Then
        ' one or more statements
    ElseIf condition2 Then
        ' one or more statements
    Else
        ' one or more statements
    End If
    ```

4. **Nested `If` Statements:**

    ```vb
    If condition1 Then
        If condition2 Then
            ' one or more statements
        End If
    End If
    ```

5. **`Select Case` Statement:**

    ```vb
    Select Case expression
        Case value1
            ' one or more statements
        Case value2
            ' one or more statements
        Case Else
            ' one or more statements
    End Select
    ```

6. **Nested `Select Case` Statements:**

    ```vb
    Select Case expression1
        Case value1
            Select Case expression2
                Case value2_1
                    ' one or more statements
                Case value2_2
                    ' one or more statements
            End Select
        Case Else
            ' one or more statements
    End Select
    ```

---

