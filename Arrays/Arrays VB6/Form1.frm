VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   8040
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form1"
   ScaleHeight     =   8040
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox List1 
      Height          =   1620
      Left            =   1800
      TabIndex        =   0
      Top             =   1680
      Width           =   2055
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim studentName(1 To 10) As String
Dim num As Integer
Dim b() As Integer


Private Sub Form_Activate()

Print "STATIC ARRAY"
Dim a(5) As Integer
a(0) = 10
a(1) = 20
a(2) = 30
a(3) = 40
a(4) = 50
For m = 0 To 4
    Print a(m)
Next

Print

Print "DYNAMIC ARRAY"


For num = 1 To 3
 studentName(num) = InputBox("Enter the student name", "DYNAMIC ARRAY")
 List1.AddItem studentName(num)
Next

ReDim b(3)
b(0) = 100
b(1) = 101
For k = 0 To 1
Print b(k)
Next

Print

Print "MULTIDIMENSIONAL ARRAY"

Dim saleVol(1 To 4, 1 To 6) As Integer
    Dim i As Integer, j As Integer

    ' Initialize the 2D array with sample values
    For i = 1 To 3
        For j = 1 To 4
            saleVol(i, j) = (i + j)
        Next j
    Next i

    ' Display the elements of the 2D array in the ListBox
    For i = 1 To 3
        Dim rowValues As String
        rowValues = "Row " & i & ":"
        For j = 1 To 4
            rowValues = rowValues & " " & saleVol(i, j)
        Next j
        List1.AddItem rowValues
    Next i


End Sub



