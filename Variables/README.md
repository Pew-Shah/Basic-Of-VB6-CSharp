# Variables


## C# :



| **C# Type Keyword** | **Storage**      | **Range of Values**                                                                                           |
|---------------------|------------------|--------------------------------------------------------------------------------------------------------------|
| bool                | 1 byte           | `True` or `False`                                                                                           |
| byte                | 1 byte           | 0 to 255                                                                                                    |
| sbyte               | 1 byte           | -128 to 127                                                                                                 |
| char                | 2 bytes          | 0 to 65,535 (Unicode characters)                                                                            |
| decimal             | 16 bytes         | ±79,228,162,514,264,337,593,543,950,335 (28 decimal places)                                                |
| double              | 8 bytes          | -1.79769313486232E+308 to 1.79769313486232E+308                                                               |
| float               | 4 bytes          | -3.402823E+38 to 3.402823E+38                                                                               |
| int                 | 4 bytes          | -2,147,483,648 to 2,147,483,647                                                                             |
| uint                | 4 bytes          | 0 to 4,294,967,295                                                                                          |
| nint                | 4 or 8 bytes     | Platform-dependent (32-bit or 64-bit)                                                                        |
| nuint               | 4 or 8 bytes     | Platform-dependent (32-bit or 64-bit)                                                                        |
| long                | 8 bytes          | -2,147,483,648 to 2,147,483,647                                                                             |
| ulong               | 8 bytes          | 0 to 18,446,744,073,709,551,615                                                                            |
| short               | 2 bytes          | -32,768 to 32,767                                                                                           |
| ushort              | 2 bytes          | 0 to 65,535                                                                                                 |
| object              | 4 bytes (reference) | Any object or value type                                                                                   |
| string              | Variable length  | 0 to 2 billion characters                                                                                     |
| dynamic             | 4 bytes (reference) | Any object or value type, dynamically typed                                                                |


### Implicit Casting:
converting a smaller type to a larger type size
char -> int -> long -> float -> double

### Explicit Casting:
converting a larger type to a smaller size type
double -> float -> long -> int -> char

## VB6 :


| **Type**              | **Storage**        | **Range of Values**                                                                                           |
|-----------------------|--------------------|--------------------------------------------------------------------------------------------------------------|
| Byte                  | 1 byte             | 0 to 255                                                                                                      |
| Integer               | 2 bytes            | -32,768 to 32,767                                                                                             |
| Long                  | 4 bytes            | -2,147,483,648 to 2,147,483,648                                                                               |
| Single                | 4 bytes            | -3.402823E+38 to -1.401298E-45 for negative values <br> 1.401298E-45 to 3.402823E+38 for positive values      |
| Double                | 8 bytes            | -1.79769313486232E+308 to -4.94065645841247E-324 for negative values <br> 4.94065645841247E-324 to 1.79769313486232E+308 for positive values|
| Currency              | 8 bytes            | -922,337,203,685,477.5808 to 922,337,203,685,477.5807                                                        |
| Decimal               | 12 bytes           | +/- 79,228,162,514,264,337,593,543,950,335 if no decimal is used <br> +/- 7.9228162514264337593543950335 (28 decimal places) |
| String (fixed length) | Length of string   | 1 to 65,400 characters                                                                                       |
| String (variable length) | Length + 10 bytes | 0 to 2 billion characters                                                                                     |
| Date                  | 8 bytes            | January 1, 100 to December 31, 9999                                                                           |
| Boolean               | 2 bytes            | True or False                                                                                                |
| Object                | 4 bytes            | Any embedded object                                                                                          |
| Variant (numeric)     | 16 bytes           | Any value as large as Double                                                                                 |
| Variant (text)        | Length + 22 bytes  | Same as variable-length string                                                                               |
