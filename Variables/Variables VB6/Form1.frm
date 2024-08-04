VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5130
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   6615
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   13.5
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   -1  'True
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   5130
   ScaleWidth      =   6615
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   615
      Left            =   3960
      TabIndex        =   0
      Top             =   3960
      Width           =   2055
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim abc As String
Dim num As Integer
Dim doDate As Date
Dim yz As Byte
Dim mn As Long
Dim pq As Single
Dim Distance As Double
Dim Price As Currency

Private Sub Command1_Click()

abc = "hello"
Print "String:" & abc

num = 10000
Print "Integer:" & num

mn = 342346234
Print "Long" & mn

pq = 123.45
Print "Single" & pq

Distance = 123456.789
Print "Distance: " & Distance

doDate = Now
Print "Date:" & doDate

yz = 100
Print "Byte:" & yz

Price = 1234.56
Print "Price: " & Format(Price, "###,##0.00")

End Sub
