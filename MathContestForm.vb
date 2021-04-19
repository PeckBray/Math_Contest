'Brayden Peck
'RCET0265
'Spring 2021
'Math Contest
'
Option Strict On
Option Explicit On
Public Class MathContestForm

    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        StudentAnswerTextBox.Enabled = False
        SubmitButton.Enabled = False
        SummeryButton.Enabled = False
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        FirstNumberTextBox.Enabled = True
        SecondNumberTextBox.Enabled = True
        StudentAnswerTextBox.Enabled = False
        SubmitButton.Enabled = False
    End Sub

    Private Sub MathProblemGroupBox_TextChanged(sender As Object, e As EventArgs) Handles MathProblemGroupBox.TextChanged
        If FirstNumberTextBox.Text = "" And SecondNumberTextBox.Text = "" Then
            StudentAnswerTextBox.Enabled = False
        Else
            StudentAnswerTextBox.Enabled = True
        End If
    End Sub





    Private Sub FirstNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNumberTextBox.TextChanged, SecondNumberTextBox.TextChanged
        Dim number1 As Boolean = NumberValidation(FirstNumberTextBox.Text)
        Dim number2 As Boolean = NumberValidation(SecondNumberTextBox.Text)
        If FirstNumberTextBox.Text = "" Then
        ElseIf SecondNumberTextBox.Text = "" Then
        ElseIf number1 = True And number2 = True Then
            StudentAnswerTextBox.Enabled = True
        End If
        MathProblemTypeGroupBox.Enabled = False
    End Sub
    Private Sub StudentAnswerTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentAnswerTextBox.TextChanged
        SubmitButton.Enabled = True
    End Sub


    Function NumberValidation(input As String) As Boolean
        Dim number As Integer
        Dim conversion As Boolean = False
        Try
            number = CInt(input)
            conversion = True
        Catch ex As Exception
        End Try
        Return (conversion)
    End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        SummeryButton.Enabled = True
        Dim grade As Integer
        Dim age As Integer
        Dim ageCheck As Boolean = NumberValidation(AgeTextBox.Text)
        Dim gradeCheck As Boolean = NumberValidation(GradeTextBox.Text)
        Dim problem As Boolean = False
        If ageCheck = True Then
            age = CInt(AgeTextBox.Text)
            If age < 7 Then
                problem = True
                MsgBox("Student not eligiable to compete.")
                AgeTextBox.Text = ""
                AgeTextBox.Focus()
            ElseIf age > 11 Then
                problem = True
                MsgBox("Student not eligiable to compete.")
                AgeTextBox.Text = ""
                AgeTextBox.Focus()
            End If
        ElseIf ageCheck = False Then
            problem = True
            MsgBox("The age must be a whole number.")
            AgeTextBox.Text = ""
            AgeTextBox.Focus()
        End If
        If gradeCheck = True And problem = False Then
            If grade > 1 Then
                problem = True
                MsgBox("Student not eligiable to compete.")
                GradeTextBox.Text = ""
                GradeTextBox.Focus()
            ElseIf grade > 4 Then
                problem = True
                MsgBox("Student not eligiable to compete.")
                GradeTextBox.Text = ""
                GradeTextBox.Focus()
            End If
        ElseIf gradeCheck = False And problem = False Then
            problem = True
            MsgBox("The Grade must be a whole number.")
            GradeTextBox.Text = ""
            GradeTextBox.Focus()
        End If
        If problem = False Then
            MathCheck()
        End If
    End Sub

    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        MathCheck()
    End Sub
    Sub MathCheck()



        Static attempts As Integer
        Static correctResponses As Integer

        If SubmitButton.Focused = True Then
            attempts += 1
            Dim number1 As Integer = CInt(FirstNumberTextBox.Text)
            Dim number2 As Integer = CInt(SecondNumberTextBox.Text)
            If NumberValidation(StudentAnswerTextBox.Text) = True Then
                Dim studentAnswer As Integer = CInt(StudentAnswerTextBox.Text)
                If AddButton.Checked = True Then
                    If number1 + number2 = studentAnswer Then
                        MsgBox("Your answer was correct")
                        correctResponses += 1
                    Else
                        MsgBox($"the correct answer is {number1 + number2}")
                    End If
                ElseIf SubtractButton.Checked = True Then
                    If number1 - number2 = studentAnswer Then
                        MsgBox("Your answer was correct")
                        correctResponses += 1
                    Else
                        MsgBox($"the correct answer is {number1 - number2}")
                    End If
                ElseIf MultiplyButton.Checked = True Then
                    If number1 * number2 = studentAnswer Then
                        MsgBox("Your answer was correct")
                        correctResponses += 1
                    Else
                        MsgBox($"the correct answer is {number1 + number2}")
                    End If
                ElseIf DivideButton.Checked = True Then
                    If number1 / number2 = studentAnswer Then
                        MsgBox("Your answer was correct")
                        correctResponses += 1
                    Else
                        MsgBox($"the correct answer is {number1 + number2}")
                    End If
                End If
            End If
            FirstNumberTextBox.Text = ""
            SecondNumberTextBox.Text = ""
            StudentAnswerTextBox.Text = ""
            MathProblemTypeGroupBox.Enabled = True
            SubmitButton.Enabled = False
        Else
            MsgBox($"{NameTextBox.Text} got {correctResponses} answers correct out of possible {attempts}")
        End If
    End Sub
End Class