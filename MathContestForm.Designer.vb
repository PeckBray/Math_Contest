<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.StudentInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.MathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MathProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.AddButton = New System.Windows.Forms.RadioButton()
        Me.SubtractButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyButton = New System.Windows.Forms.RadioButton()
        Me.DivideButton = New System.Windows.Forms.RadioButton()
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummeryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.StudentInformationGroupBox.SuspendLayout()
        Me.MathProblemGroupBox.SuspendLayout()
        Me.MathProblemTypeGroupBox.SuspendLayout()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInformationGroupBox
        '
        Me.StudentInformationGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInformationGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInformationGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInformationGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInformationGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInformationGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInformationGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.StudentInformationGroupBox.Name = "StudentInformationGroupBox"
        Me.StudentInformationGroupBox.Size = New System.Drawing.Size(491, 94)
        Me.StudentInformationGroupBox.TabIndex = 0
        Me.StudentInformationGroupBox.TabStop = False
        Me.StudentInformationGroupBox.Text = "Student Information"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeLabel.Location = New System.Drawing.Point(253, 34)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 9
        Me.AgeLabel.Text = "Age"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeLabel.Location = New System.Drawing.Point(345, 34)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(54, 20)
        Me.GradeLabel.TabIndex = 8
        Me.GradeLabel.Text = "Grade"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(257, 57)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(38, 26)
        Me.AgeTextBox.TabIndex = 2
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeTextBox.Location = New System.Drawing.Point(349, 57)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(39, 26)
        Me.GradeTextBox.TabIndex = 3
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(6, 34)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(51, 20)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(6, 57)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(201, 26)
        Me.NameTextBox.TabIndex = 1
        Me.NameTextBox.Tag = ""
        '
        'MathProblemGroupBox
        '
        Me.MathProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.MathProblemGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MathProblemGroupBox.Location = New System.Drawing.Point(8, 178)
        Me.MathProblemGroupBox.Name = "MathProblemGroupBox"
        Me.MathProblemGroupBox.Size = New System.Drawing.Size(199, 248)
        Me.MathProblemGroupBox.TabIndex = 1
        Me.MathProblemGroupBox.TabStop = False
        Me.MathProblemGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(6, 197)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(107, 17)
        Me.StudentAnswerLabel.TabIndex = 5
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(4, 120)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(86, 17)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(6, 219)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(130, 23)
        Me.StudentAnswerTextBox.TabIndex = 3
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNumberLabel.Location = New System.Drawing.Point(6, 54)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(81, 17)
        Me.FirstNumberLabel.TabIndex = 2
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(6, 145)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(130, 26)
        Me.SecondNumberTextBox.TabIndex = 1
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(6, 77)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(130, 26)
        Me.FirstNumberTextBox.TabIndex = 0
        '
        'MathProblemTypeGroupBox
        '
        Me.MathProblemTypeGroupBox.Controls.Add(Me.AddButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.SubtractButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.MultiplyButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.DivideButton)
        Me.MathProblemTypeGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MathProblemTypeGroupBox.Location = New System.Drawing.Point(270, 178)
        Me.MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox"
        Me.MathProblemTypeGroupBox.Size = New System.Drawing.Size(221, 248)
        Me.MathProblemTypeGroupBox.TabIndex = 2
        Me.MathProblemTypeGroupBox.TabStop = False
        Me.MathProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'AddButton
        '
        Me.AddButton.AutoSize = True
        Me.AddButton.Checked = True
        Me.AddButton.Location = New System.Drawing.Point(54, 77)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(51, 21)
        Me.AddButton.TabIndex = 3
        Me.AddButton.TabStop = True
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'SubtractButton
        '
        Me.SubtractButton.AutoSize = True
        Me.SubtractButton.Location = New System.Drawing.Point(54, 116)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(79, 21)
        Me.SubtractButton.TabIndex = 4
        Me.SubtractButton.Text = "Subtract"
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'MultiplyButton
        '
        Me.MultiplyButton.AutoSize = True
        Me.MultiplyButton.Location = New System.Drawing.Point(54, 159)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(73, 21)
        Me.MultiplyButton.TabIndex = 5
        Me.MultiplyButton.TabStop = True
        Me.MultiplyButton.Text = "Multiply"
        Me.MultiplyButton.UseVisualStyleBackColor = True
        '
        'DivideButton
        '
        Me.DivideButton.AutoSize = True
        Me.DivideButton.Location = New System.Drawing.Point(54, 195)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(65, 21)
        Me.DivideButton.TabIndex = 6
        Me.DivideButton.TabStop = True
        Me.DivideButton.Text = "Divide"
        Me.DivideButton.UseVisualStyleBackColor = True
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SummeryButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(510, 0)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(264, 426)
        Me.ButtonsGroupBox.TabIndex = 3
        Me.ButtonsGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(11, 304)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(247, 54)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummeryButton
        '
        Me.SummeryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummeryButton.Location = New System.Drawing.Point(11, 222)
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(247, 54)
        Me.SummeryButton.TabIndex = 2
        Me.SummeryButton.Text = "Summery"
        Me.SummeryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(11, 138)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(247, 54)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.Location = New System.Drawing.Point(11, 57)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(247, 54)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'MathContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.Controls.Add(Me.MathProblemTypeGroupBox)
        Me.Controls.Add(Me.MathProblemGroupBox)
        Me.Controls.Add(Me.StudentInformationGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.StudentInformationGroupBox.ResumeLayout(False)
        Me.StudentInformationGroupBox.PerformLayout()
        Me.MathProblemGroupBox.ResumeLayout(False)
        Me.MathProblemGroupBox.PerformLayout()
        Me.MathProblemTypeGroupBox.ResumeLayout(False)
        Me.MathProblemTypeGroupBox.PerformLayout()
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInformationGroupBox As GroupBox
    Friend WithEvents MathProblemGroupBox As GroupBox
    Friend WithEvents MathProblemTypeGroupBox As GroupBox
    Friend WithEvents ButtonsGroupBox As GroupBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents AddButton As RadioButton
    Friend WithEvents SubtractButton As RadioButton
    Friend WithEvents MultiplyButton As RadioButton
    Friend WithEvents DivideButton As RadioButton
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummeryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
End Class
