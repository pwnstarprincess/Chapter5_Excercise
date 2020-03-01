Public Class gpaForm

    ''Dim creditHours As Double
    Dim runningGPA As Double
    Dim totalCredits As Double

    Private Sub RecordCourse(grade As Char, credits As Double)

        Select Case grade
            Case "A", "a"
                runningGPA += credits * 4
            Case "B", "b"
                runningGPA += credits * 3
            Case "C", "c"
                runningGPA += credits * 2
            Case "D", "d"
                runningGPA += credits * 1
            Case "F", "f"
                runningGPA += credits * 0
            Case Else
                System.Console.WriteLine("Invalid")

        End Select

        totalCredits += credits

        gradeText.Clear()
        creditText.Clear()

    End Sub

    Private Function GetGrade() As Char

        Return Convert.ToChar(gradeText.Text)

    End Function

    Private Function GetCreditHours() As Double

        Return Convert.ToDouble(creditText.Text)

    End Function

    Private Function GetRunningGPA() As Double

        Return Math.Round(runningGPA / totalCredits, 2)

    End Function

    Private Sub DisplayGPA()
        gpaResults.Text = Convert.ToString(GetRunningGPA())
    End Sub

    Private Sub RecordCourseButton_Click(sender As Object, e As EventArgs) Handles recordCourseButton.Click

        RecordCourse(GetGrade(), GetCreditHours())

    End Sub

    Private Sub calculateGpaButton_Click(sender As Object, e As EventArgs) Handles calculateGpaButton.Click
        DisplayGPA()
    End Sub
End Class
