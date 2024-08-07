VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   7845
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   7290
   LinkTopic       =   "Form1"
   ScaleHeight     =   7845
   ScaleWidth      =   7290
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Function sum(ByVal x As Integer, ByVal y As Integer) As Integer
    Dim z As Integer
    z = x + y
    sum = z
End Function

Public Function tables(ByVal m As Integer) As Integer
    Dim k As Integer
    For i = 1 To 10
        Print m & " *" & i & " =" & (m * i)
    Next i
    tables = k
End Function

' Sub Procedure to calculate the square of an integer and display it
Public Sub SquareInteger(ByVal x As Integer)
    Dim result1 As Integer
    
    result1 = x * x
    Print "The square of " & x & " is: " & result1
End Sub

Private Sub Form_Activate()
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim input1 As String
    Dim input2 As String
    Dim l As Integer
    Dim result As String

    input1 = InputBox("Enter the first number:", "Input Required")
    input2 = InputBox("Enter the second number:", "Input Required")
    a = Val(input1)
    b = Val(input2)
    c = sum(a, b)
    Print "The sum is: " & c
    
    input3 = InputBox("Enter integer: ", "Input Required")
    l = Val(input3)
    result = tables(l)
    
    input4 = InputBox("enter number: ")
    Dim t As Integer
    SquareInteger input4
    
    
    
End Sub

