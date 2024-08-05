# Input and Output :

## C# Output : 

In order to output something in C#, we can use

System.Console.WriteLine() OR
System.Console.Write()

The main difference between WriteLine() and Write() is that the Write() method only prints the string provided to it, while the WriteLine() method prints the string and moves to the start of next line as well.


## C# Input :

In C#, the simplest method to get input from the user is by using the ReadLine() method of the Console class. However, Read() and ReadKey() are also available for getting input from the user.

The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type, such as int. 

Reading numeric values can be slightly tricky in C#. We’ll still use the same ReadLine() method we used for getting string values. But since the ReadLine() method receives the input as string, it needs to be converted into integer or floating point type.

One simple approach for converting our input is using the methods of Convert class.
The ToInt32() and ToDouble() method of Convert class converts the string input to integer and double type respectively. Similarly we can convert the input to other types. 

* ReadLine(): The ReadLine() method reads the next line of input from the standard input stream. It returns the same string.
* Read(): The Read() method reads the next character from the standard input stream. It returns the ascii value of the character.
* ReadKey(): The ReadKey() method obtains the next key pressed by user. This method is usually used to hold the screen until user press a key.