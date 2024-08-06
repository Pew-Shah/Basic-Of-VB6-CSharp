VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   10755
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   10860
   LinkTopic       =   "Form1"
   ScaleHeight     =   10755
   ScaleWidth      =   10860
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim i As Integer
Dim x As Integer
Dim num As Integer
Dim d As Integer
Dim e As Integer
Dim p As Integer
Dim q As Integer
Dim l As Integer
Dim m As Integer


Private Sub Form_Activate()

Print "for loop"
For i = 1 To 5
Print i
Next i

Print "nested for loop"
For p = 1 To 3
        ' Loop through columns (q)
        For q = 1 To 3
            ' Print the coordinate (p, q), use a tab character for spacing
            Print "(" & p & ", " & q & ")" & vbTab;
        Next q
        ' Move to the next line after each row
        Print
    Next p


Print "do while loop"
Do While x < 4
    Print "hello"
    x = x + 1
Loop

num = 0
Do
    Print num
    num = num + 1
Loop While num <= 10

Print "do until loop"

d = 0
Do
    d = d + 1
Loop Until d > 10

e = 0
Do Until e > 4
    Print e
    e = e + 1
Loop

Print "exit do"

Do While l <= 10
        If l = 5 Then
            Exit Do
        End If
        Print l
        l = l + 1
Loop
    
Print "exit for"

For m = 1 To 10
        If m = 6 Then
            Exit For
        End If
        Print m
    Next m

Print "while wend loop"
Dim count As Integer
count = 1

    While count <= 9
        Print count
        count = count + 1
    Wend

End Sub




