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
Private Sub Form_Load()
    Dim age As Integer
    Dim country As String
    Dim grade As Integer

    
    age = 25
    country = "USA"
    grade = 85

    ' Basic If...Then statement
    If age >= 18 Then
        MsgBox "You are an adult. (Basic If...Then statement evaluated: age >= 18)"
    End If

    ' If...Then...Else statement
    If age >= 18 Then
        MsgBox "You are an adult. (If...Then...Else statement evaluated: age >= 18)"
    Else
        MsgBox "You are not an adult. (If...Then...Else statement evaluated: age < 18)"
    End If

    ' If...Then...ElseIf...Else statement
    If grade >= 90 Then
        MsgBox "Grade: A (If...Then...ElseIf...Else statement evaluated: grade >= 90)"
    ElseIf grade >= 80 Then
        MsgBox "Grade: B (If...Then...ElseIf...Else statement evaluated: grade >= 80)"
    ElseIf grade >= 70 Then
        MsgBox "Grade: C (If...Then...ElseIf...Else statement evaluated: grade >= 70)"
    Else
        MsgBox "Grade: F (If...Then...ElseIf...Else statement evaluated: grade < 70)"
    End If

    ' Nested If...Then statements
    If age >= 18 Then
        If country = "USA" Then
            MsgBox "You can vote in the USA. (Nested If...Then statement evaluated: age >= 18 and country = USA)"
        Else
            MsgBox "You might be able to vote in your country. (Nested If...Then statement evaluated: age >= 18 and country <> USA)"
        End If
    Else
        MsgBox "You are not eligible to vote. (Nested If...Then statement evaluated: age < 18)"
    End If

    ' Select Case statement
    Select Case grade
        Case Is >= 90
            MsgBox "Grade: A (Select Case statement evaluated: grade >= 90)"
        Case Is >= 80
            MsgBox "Grade: B (Select Case statement evaluated: grade >= 80)"
        Case Is >= 70
            MsgBox "Grade: C (Select Case statement evaluated: grade >= 70)"
        Case Else
            MsgBox "Grade: F (Select Case statement evaluated: grade < 70)"
    End Select
End Sub

