<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreate))
        Me.TxtQuestion = New System.Windows.Forms.TextBox()
        Me.TxtAnswer1 = New System.Windows.Forms.TextBox()
        Me.LblQuestionNum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAnswer2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAnswer3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAnswer4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboCorrect = New System.Windows.Forms.ComboBox()
        Me.ToolStrpCreator = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownFile = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TsbSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsbLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfdCreator = New System.Windows.Forms.OpenFileDialog()
        Me.SfdCreator = New System.Windows.Forms.SaveFileDialog()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.ToolStrpCreator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtQuestion
        '
        Me.TxtQuestion.Location = New System.Drawing.Point(15, 53)
        Me.TxtQuestion.Multiline = True
        Me.TxtQuestion.Name = "TxtQuestion"
        Me.TxtQuestion.Size = New System.Drawing.Size(613, 62)
        Me.TxtQuestion.TabIndex = 0
        '
        'TxtAnswer1
        '
        Me.TxtAnswer1.Location = New System.Drawing.Point(15, 147)
        Me.TxtAnswer1.Multiline = True
        Me.TxtAnswer1.Name = "TxtAnswer1"
        Me.TxtAnswer1.Size = New System.Drawing.Size(613, 43)
        Me.TxtAnswer1.TabIndex = 1
        '
        'LblQuestionNum
        '
        Me.LblQuestionNum.AutoSize = True
        Me.LblQuestionNum.Location = New System.Drawing.Point(15, 35)
        Me.LblQuestionNum.Name = "LblQuestionNum"
        Me.LblQuestionNum.Size = New System.Drawing.Size(65, 15)
        Me.LblQuestionNum.TabIndex = 2
        Me.LblQuestionNum.Text = "Question X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Answer 1"
        '
        'TxtAnswer2
        '
        Me.TxtAnswer2.Location = New System.Drawing.Point(15, 211)
        Me.TxtAnswer2.Multiline = True
        Me.TxtAnswer2.Name = "TxtAnswer2"
        Me.TxtAnswer2.Size = New System.Drawing.Size(613, 43)
        Me.TxtAnswer2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Answer 2"
        '
        'TxtAnswer3
        '
        Me.TxtAnswer3.Location = New System.Drawing.Point(15, 278)
        Me.TxtAnswer3.Multiline = True
        Me.TxtAnswer3.Name = "TxtAnswer3"
        Me.TxtAnswer3.Size = New System.Drawing.Size(613, 43)
        Me.TxtAnswer3.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Answer 3"
        '
        'TxtAnswer4
        '
        Me.TxtAnswer4.Location = New System.Drawing.Point(15, 342)
        Me.TxtAnswer4.Multiline = True
        Me.TxtAnswer4.Name = "TxtAnswer4"
        Me.TxtAnswer4.Size = New System.Drawing.Size(613, 43)
        Me.TxtAnswer4.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Answer 4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correct answer"
        '
        'CboCorrect
        '
        Me.CboCorrect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCorrect.FormattingEnabled = True
        Me.CboCorrect.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CboCorrect.Location = New System.Drawing.Point(15, 406)
        Me.CboCorrect.Name = "CboCorrect"
        Me.CboCorrect.Size = New System.Drawing.Size(121, 23)
        Me.CboCorrect.TabIndex = 5
        '
        'ToolStrpCreator
        '
        Me.ToolStrpCreator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrpCreator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownFile})
        Me.ToolStrpCreator.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrpCreator.Name = "ToolStrpCreator"
        Me.ToolStrpCreator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrpCreator.Size = New System.Drawing.Size(644, 25)
        Me.ToolStrpCreator.TabIndex = 11
        Me.ToolStrpCreator.Text = "ToolStrip1"
        '
        'ToolStripDropDownFile
        '
        Me.ToolStripDropDownFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbSave, Me.TsbLoad})
        Me.ToolStripDropDownFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownFile.Name = "ToolStripDropDownFile"
        Me.ToolStripDropDownFile.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripDropDownFile.Text = "&File"
        '
        'TsbSave
        '
        Me.TsbSave.Name = "TsbSave"
        Me.TsbSave.Size = New System.Drawing.Size(100, 22)
        Me.TsbSave.Text = "&Save"
        '
        'TsbLoad
        '
        Me.TsbLoad.Name = "TsbLoad"
        Me.TsbLoad.Size = New System.Drawing.Size(100, 22)
        Me.TsbLoad.Text = "&Load"
        '
        'OfdCreator
        '
        Me.OfdCreator.FileName = "quiz.qz"
        Me.OfdCreator.Filter = "Quizzer files|*.qz"
        '
        'SfdCreator
        '
        Me.SfdCreator.FileName = "quiz.qz"
        Me.SfdCreator.Filter = "Quizzer file|*.qz"
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(553, 405)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 10
        Me.BtnNext.Text = "&Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(472, 405)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrevious.TabIndex = 9
        Me.BtnPrevious.Text = "Pre&vious"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(170, 405)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(86, 23)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "&Add new"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(262, 405)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(86, 23)
        Me.BtnInsert.TabIndex = 7
        Me.BtnInsert.Text = "&Insert new"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(354, 405)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(86, 23)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'FrmCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 443)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.ToolStrpCreator)
        Me.Controls.Add(Me.CboCorrect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtAnswer4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtAnswer3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblQuestionNum)
        Me.Controls.Add(Me.TxtAnswer2)
        Me.Controls.Add(Me.TxtAnswer1)
        Me.Controls.Add(Me.TxtQuestion)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizzer - [Quiz Creator]"
        Me.ToolStrpCreator.ResumeLayout(False)
        Me.ToolStrpCreator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtQuestion As TextBox
    Friend WithEvents TxtAnswer1 As TextBox
    Friend WithEvents LblQuestionNum As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAnswer2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAnswer3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAnswer4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CboCorrect As ComboBox
    Friend WithEvents ToolStrpCreator As ToolStrip
    Friend WithEvents ToolStripDropDownFile As ToolStripDropDownButton
    Friend WithEvents TsbSave As ToolStripMenuItem
    Friend WithEvents TsbLoad As ToolStripMenuItem
    Friend WithEvents OfdCreator As OpenFileDialog
    Friend WithEvents SfdCreator As SaveFileDialog
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnInsert As Button
    Friend WithEvents BtnDelete As Button
End Class
