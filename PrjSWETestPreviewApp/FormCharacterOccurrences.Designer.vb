<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCharacterOccurrences
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
        Me.TxtInputString = New System.Windows.Forms.TextBox()
        Me.TxtChars = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAnswer = New System.Windows.Forms.TextBox()
        Me.BtnProcess = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtInputString
        '
        Me.TxtInputString.Location = New System.Drawing.Point(17, 41)
        Me.TxtInputString.Multiline = True
        Me.TxtInputString.Name = "TxtInputString"
        Me.TxtInputString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtInputString.Size = New System.Drawing.Size(165, 96)
        Me.TxtInputString.TabIndex = 0
        '
        'TxtChars
        '
        Me.TxtChars.Location = New System.Drawing.Point(14, 169)
        Me.TxtChars.Name = "TxtChars"
        Me.TxtChars.Size = New System.Drawing.Size(165, 20)
        Me.TxtChars.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tekst"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Otsitavad tähed"
        '
        'TxtAnswer
        '
        Me.TxtAnswer.Location = New System.Drawing.Point(6, 22)
        Me.TxtAnswer.Multiline = True
        Me.TxtAnswer.Name = "TxtAnswer"
        Me.TxtAnswer.ReadOnly = True
        Me.TxtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAnswer.Size = New System.Drawing.Size(170, 183)
        Me.TxtAnswer.TabIndex = 4
        '
        'BtnProcess
        '
        Me.BtnProcess.Location = New System.Drawing.Point(214, 116)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(102, 23)
        Me.BtnProcess.TabIndex = 5
        Me.BtnProcess.Text = "Töötle"
        Me.BtnProcess.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtInputString)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtChars)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 211)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sisendid"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtAnswer)
        Me.GroupBox2.Location = New System.Drawing.Point(322, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 211)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tulemused"
        '
        'FormCharacterOccurrences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 237)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnProcess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCharacterOccurrences"
        Me.Text = "Tarkvaratehnika projekti näidistest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtInputString As TextBox
    Friend WithEvents TxtChars As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAnswer As TextBox
    Friend WithEvents BtnProcess As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
