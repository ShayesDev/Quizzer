<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTake
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTake))
        Me.RdoAnswer1 = New System.Windows.Forms.RadioButton()
        Me.LblQuestionNum = New System.Windows.Forms.Label()
        Me.LblQuestion = New System.Windows.Forms.Label()
        Me.RdoAnswer2 = New System.Windows.Forms.RadioButton()
        Me.RdoAnswer3 = New System.Windows.Forms.RadioButton()
        Me.RdoAnswer4 = New System.Windows.Forms.RadioButton()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnResults = New System.Windows.Forms.Button()
        Me.LblCorrect = New System.Windows.Forms.Label()
        Me.LblIncorrect = New System.Windows.Forms.Label()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RdoAnswer1
        '
        Me.RdoAnswer1.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RdoAnswer1.Location = New System.Drawing.Point(49, 109)
        Me.RdoAnswer1.Name = "RdoAnswer1"
        Me.RdoAnswer1.Size = New System.Drawing.Size(544, 66)
        Me.RdoAnswer1.TabIndex = 0
        Me.RdoAnswer1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RdoAnswer1.UseVisualStyleBackColor = True
        '
        'LblQuestionNum
        '
        Me.LblQuestionNum.AutoSize = True
        Me.LblQuestionNum.Location = New System.Drawing.Point(12, 9)
        Me.LblQuestionNum.Name = "LblQuestionNum"
        Me.LblQuestionNum.Size = New System.Drawing.Size(89, 15)
        Me.LblQuestionNum.TabIndex = 1
        Me.LblQuestionNum.Text = "Question X of X"
        '
        'LblQuestion
        '
        Me.LblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblQuestion.Location = New System.Drawing.Point(49, 33)
        Me.LblQuestion.Name = "LblQuestion"
        Me.LblQuestion.Size = New System.Drawing.Size(544, 62)
        Me.LblQuestion.TabIndex = 2
        '
        'RdoAnswer2
        '
        Me.RdoAnswer2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RdoAnswer2.Location = New System.Drawing.Point(49, 181)
        Me.RdoAnswer2.Name = "RdoAnswer2"
        Me.RdoAnswer2.Size = New System.Drawing.Size(544, 66)
        Me.RdoAnswer2.TabIndex = 1
        Me.RdoAnswer2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RdoAnswer2.UseVisualStyleBackColor = True
        '
        'RdoAnswer3
        '
        Me.RdoAnswer3.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RdoAnswer3.Location = New System.Drawing.Point(49, 253)
        Me.RdoAnswer3.Name = "RdoAnswer3"
        Me.RdoAnswer3.Size = New System.Drawing.Size(544, 66)
        Me.RdoAnswer3.TabIndex = 2
        Me.RdoAnswer3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RdoAnswer3.UseVisualStyleBackColor = True
        '
        'RdoAnswer4
        '
        Me.RdoAnswer4.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RdoAnswer4.Location = New System.Drawing.Point(49, 325)
        Me.RdoAnswer4.Name = "RdoAnswer4"
        Me.RdoAnswer4.Size = New System.Drawing.Size(544, 66)
        Me.RdoAnswer4.TabIndex = 3
        Me.RdoAnswer4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RdoAnswer4.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(96, 408)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 5
        Me.BtnNext.Text = "&Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(15, 408)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrevious.TabIndex = 4
        Me.BtnPrevious.Text = "Pre&vious"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnResults
        '
        Me.BtnResults.Enabled = False
        Me.BtnResults.Location = New System.Drawing.Point(527, 408)
        Me.BtnResults.Name = "BtnResults"
        Me.BtnResults.Size = New System.Drawing.Size(105, 23)
        Me.BtnResults.TabIndex = 6
        Me.BtnResults.Text = "View &results"
        Me.BtnResults.UseVisualStyleBackColor = True
        '
        'LblCorrect
        '
        Me.LblCorrect.AutoSize = True
        Me.LblCorrect.ForeColor = System.Drawing.Color.Green
        Me.LblCorrect.Location = New System.Drawing.Point(547, 9)
        Me.LblCorrect.Name = "LblCorrect"
        Me.LblCorrect.Size = New System.Drawing.Size(46, 15)
        Me.LblCorrect.TabIndex = 7
        Me.LblCorrect.Text = "Correct"
        Me.LblCorrect.Visible = False
        '
        'LblIncorrect
        '
        Me.LblIncorrect.AutoSize = True
        Me.LblIncorrect.ForeColor = System.Drawing.Color.Crimson
        Me.LblIncorrect.Location = New System.Drawing.Point(539, 9)
        Me.LblIncorrect.Name = "LblIncorrect"
        Me.LblIncorrect.Size = New System.Drawing.Size(54, 15)
        Me.LblIncorrect.TabIndex = 7
        Me.LblIncorrect.Text = "Incorrect"
        Me.LblIncorrect.Visible = False
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.Location = New System.Drawing.Point(177, 412)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(83, 15)
        Me.LblScore.TabIndex = 8
        Me.LblScore.Text = "Score: XX.XX%"
        Me.LblScore.Visible = False
        '
        'FrmTake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 443)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.LblIncorrect)
        Me.Controls.Add(Me.LblCorrect)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnResults)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.LblQuestion)
        Me.Controls.Add(Me.LblQuestionNum)
        Me.Controls.Add(Me.RdoAnswer4)
        Me.Controls.Add(Me.RdoAnswer3)
        Me.Controls.Add(Me.RdoAnswer2)
        Me.Controls.Add(Me.RdoAnswer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmTake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizzer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RdoAnswer1 As RadioButton
    Friend WithEvents LblQuestionNum As Label
    Friend WithEvents LblQuestion As Label
    Friend WithEvents RdoAnswer2 As RadioButton
    Friend WithEvents RdoAnswer3 As RadioButton
    Friend WithEvents RdoAnswer4 As RadioButton
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnResults As Button
    Friend WithEvents LblCorrect As Label
    Friend WithEvents LblIncorrect As Label
    Friend WithEvents LblScore As Label
End Class
