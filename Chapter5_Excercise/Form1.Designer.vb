<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GpaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.recordCourseButton = New System.Windows.Forms.Button()
        Me.calculateGpaButton = New System.Windows.Forms.Button()
        Me.gpaResults = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gradeText = New System.Windows.Forms.MaskedTextBox()
        Me.creditText = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'recordCourseButton
        '
        Me.recordCourseButton.Location = New System.Drawing.Point(149, 192)
        Me.recordCourseButton.Name = "recordCourseButton"
        Me.recordCourseButton.Size = New System.Drawing.Size(232, 51)
        Me.recordCourseButton.TabIndex = 0
        Me.recordCourseButton.Text = "Record This Course"
        Me.recordCourseButton.UseVisualStyleBackColor = True
        '
        'calculateGpaButton
        '
        Me.calculateGpaButton.Location = New System.Drawing.Point(149, 298)
        Me.calculateGpaButton.Name = "calculateGpaButton"
        Me.calculateGpaButton.Size = New System.Drawing.Size(232, 51)
        Me.calculateGpaButton.TabIndex = 1
        Me.calculateGpaButton.Text = "Calculate GPA"
        Me.calculateGpaButton.UseVisualStyleBackColor = True
        '
        'gpaResults
        '
        Me.gpaResults.Location = New System.Drawing.Point(276, 376)
        Me.gpaResults.Name = "gpaResults"
        Me.gpaResults.ReadOnly = True
        Me.gpaResults.Size = New System.Drawing.Size(100, 26)
        Me.gpaResults.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GPA:  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Grade (A,B,...):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Credit hours:  "
        '
        'gradeText
        '
        Me.gradeText.Location = New System.Drawing.Point(276, 55)
        Me.gradeText.Mask = "L"
        Me.gradeText.Name = "gradeText"
        Me.gradeText.Size = New System.Drawing.Size(45, 26)
        Me.gradeText.TabIndex = 8
        '
        'creditText
        '
        Me.creditText.Location = New System.Drawing.Point(276, 118)
        Me.creditText.Mask = "#"
        Me.creditText.Name = "creditText"
        Me.creditText.Size = New System.Drawing.Size(45, 26)
        Me.creditText.TabIndex = 9
        '
        'GpaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 472)
        Me.Controls.Add(Me.creditText)
        Me.Controls.Add(Me.gradeText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpaResults)
        Me.Controls.Add(Me.calculateGpaButton)
        Me.Controls.Add(Me.recordCourseButton)
        Me.Name = "GpaForm"
        Me.Text = "GPA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents recordCourseButton As Button
    Friend WithEvents calculateGpaButton As Button
    Friend WithEvents gpaResults As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gradeText As MaskedTextBox
    Friend WithEvents creditText As MaskedTextBox
End Class
