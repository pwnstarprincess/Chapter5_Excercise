''Jennifer Pezzulo
''March 3, 2020
''Chapter 5 Excercise Programming Project 1 (Grade Point Average)

''Turn Explicit mode on
Option Explicit On

Public Class GpaForm

    ''Variables to hold total points earned and total credits attempted
    Dim totalPointsEarned As Double
    Dim totalCreditsAttempted As Double

    ''Subroutine for recording course grading information.  Takes grade achieved and credit hours as variables.
    ''Converts letter grade to numeric value.  Updates totalPointsEarned and totalCreditsAttempted.  Clears text fields after updating variables.
    Private Sub RecordCourse(grade As Char, credits As Double)
        ''Select case statement to translate letter Grade to numeric value.  
        ''Update totalPointsEarned
        ''Accepts lower case and upper case value for letter grade.
        ''Output to console in the event of any "unexpected data" 
        Select Case grade
            Case "A", "a"
                totalPointsEarned += credits * 4
            Case "B", "b"
                totalPointsEarned += credits * 3
            Case "C", "c"
                totalPointsEarned += credits * 2
            Case "D", "d"
                totalPointsEarned += credits * 1
            Case "F", "f"
                totalPointsEarned += credits * 0
            Case Else
                System.Console.WriteLine("Invalid")

        End Select
        ''Update total credits hours attempted
        totalCreditsAttempted += credits
        ''Clear masked text boxes 
        gradeText.Clear()
        creditText.Clear()

    End Sub

    ''Function that returns the grade entered in "Grade" masked text box on the gpa form.  The data is returned as Char data type
    Private Function GetGrade() As Char

        Return Convert.ToChar(gradeText.Text)

    End Function
    ''Function that returns the credit hours entered in "Credit Hours" masked text box on the gpa form.  The data is returned as Double data type
    Private Function GetCreditHours() As Double

        Return Convert.ToDouble(creditText.Text)

    End Function
    ''Returns the running GPA divided by the total credits earned.  The Value is rounded to two decimal places 
    Private Function GetRunningGPA() As Double
        ''Total GPA = Total Points earned / Total Credits attempted.  Round to two decimal places
        Return Math.Round(totalPointsEarned / totalCreditsAttempted, 2)

    End Function

    ''Subroutine to display the running GPA in the GPA read-only text box
    Private Sub DisplayGPA()
        gpaResults.Text = GetRunningGPA().ToString("#.0#")

    End Sub
    ''Subroutine to handle click of "Record the Course" Button.  Calls the RecordCourse Subroutine
    Private Sub RecordCourseButton_Click(sender As Object, e As EventArgs) Handles recordCourseButton.Click
        ''Record the course.  Pass in Grade and Credit hours
        RecordCourse(GetGrade(), GetCreditHours())

    End Sub
    ''Subroutine to handle click of the "Calculate GPA" button.  Calls the DisplayGPA subroutine
    Private Sub CalculateGpaButton_Click(sender As Object, e As EventArgs) Handles calculateGpaButton.Click
        DisplayGPA()
    End Sub
End Class
