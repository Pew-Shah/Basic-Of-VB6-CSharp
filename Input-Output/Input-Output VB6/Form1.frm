VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form1"
   ScaleHeight     =   3015
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim A As Integer
Dim B As Double
Dim C As String

Private Sub Form_Load()
 ' Get inputs for A, B, and C
    A = Val(InputBox("Enter value of A", "A"))
    B = Val(InputBox("Enter value of B", "B"))
    C = InputBox("Enter value of C", "C")

    ' Display the values of A, B, and C
    MsgBox "Value of A is " & A & vbCrLf & "Value of B is " & B & vbCrLf & "String Entered: " & C
    
    ' Additional task to get and show value of n
    Dim n As Integer
    n = Val(InputBox("Enter the value of n:", "Enter n"))
    MsgBox "The value of n is " & n
    
    ' Additional predefined value of n
    n = 10
    MsgBox "The predefined value of n is " & n
    
    ' Close the form after displaying the messages
    Unload Me
End Sub
