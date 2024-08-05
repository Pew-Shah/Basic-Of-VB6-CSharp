# Input and Output :


# C# :


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


# VB6 :


## VB6 Output : 


### MsgBox
The MsgBox function shows a dialog box displaying the output value or a message.

Syntax

|MsgBox Prompt, [MsgBox style], [Title]|
|--------------------------------------|


where Promt text is the prompt message, [MsgBox Style] is the msgbox style constants and [Title] is the text displayed in the title bar of the MsgBox dialog.



## VB6 Input :


### InputBox
InputBox is a function that prompts for user-input. InputBox shows a dialog box that inputs value from the user.

Syntax
|a=InputBox( promt, [Title], [Default], [xpos], [ypos])|
|------------------------------------------------------|

where 'a' is a variable to which the value will be assigned. The texts inside the InputBox are optional except the "prompt" text. "prompt" text is the prompt message. "title" is the title of the message box window. "Default" is the default value given by the programmer. 'xpos' and 'ypos' are the geometric positions with respect to x and y axis respectively.

### Output using PictureBox
PictureBox is also used for the output operation. The output is displayed using the Print method.

### Input and output using TextBox
The TextBox Control provides an efficient way for both input and operations.