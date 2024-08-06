# Conditional Statements:

## C# :


| **Sr.No.** | **Statements**             | **Description**                                                                                          |
|------------|----------------------------|----------------------------------------------------------------------------------------------------------|
| 1          | `if` Statement             | An `if` statement consists of a boolean expression followed by one or more statements.                   |
| 2          | `if...else` Statement      | An `if` statement can be followed by an optional `else` statement, which executes when the boolean expression is false. |
| 3          | `else if` Statement        | Used in conjunction with `if` and `else` to test additional conditions if the previous conditions are false. |
| 4          | Nested `if` Statements     | You can use one `if` or `else if` statement inside another `if` or `else if` statement(s).               |
| 5          | `switch` Statement         | A `switch` statement allows a variable to be tested for equality against a list of values.               |
| 6          | Nested `switch` Statements | You can use one `switch` statement inside another `switch` statement(s).                                |


## VB6 :

Sure! Here is the table with descriptions of various VB6 conditional statements:

| **Sr.No.** | **Statements**                   | **Description**                                                                                          |
|------------|----------------------------------|----------------------------------------------------------------------------------------------------------|
| 1          | `If` Statement                   | An `If` statement consists of a boolean expression followed by one or more statements.                   |
| 2          | `If...Then...Else` Statement     | An `If` statement can be followed by an optional `Else` statement, which executes when the boolean expression is false. |
| 3          | `If...Then...ElseIf...Else` Statement | Used in conjunction with `If` and `Else` to test additional conditions if the previous conditions are false. |
| 4          | Nested `If` Statements           | You can use one `If` or `ElseIf` statement inside another `If` or `ElseIf` statement(s).                 |
| 5          | `Select Case` Statement          | A `Select Case` statement allows a variable to be tested for equality against a list of values.          |
| 6          | Nested `Select Case` Statements  | You can use one `Select Case` statement inside another `Select Case` statement(s).                       |

This table provides an overview of the conditional statements in VB6, along with their descriptions.


### Syntax :

Certainly! Here is the syntax for each type of conditional statement in VB6, presented plainly:

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