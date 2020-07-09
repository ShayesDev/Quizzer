<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.BtnTake = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.OfdTake = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'BtnTake
        '
        Me.BtnTake.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnTake.Location = New System.Drawing.Point(74, 89)
        Me.BtnTake.Name = "BtnTake"
        Me.BtnTake.Size = New System.Drawing.Size(150, 150)
        Me.BtnTake.TabIndex = 0
        Me.BtnTake.Text = "&Take quiz"
        Me.BtnTake.UseVisualStyleBackColor = False
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnCreate.Location = New System.Drawing.Point(279, 89)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(150, 150)
        Me.BtnCreate.TabIndex = 1
        Me.BtnCreate.Text = "&Create quiz"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'OfdTake
        '
        Me.OfdTake.AddExtension = False
        Me.OfdTake.Filter = "Quizzer files|*.qz"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 329)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.BtnTake)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizzer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnTake As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents OfdTake As OpenFileDialog
End Class
