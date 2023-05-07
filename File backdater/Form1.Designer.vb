<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lastaccessChkBox = New System.Windows.Forms.CheckBox()
        Me.lastwriteChkBox = New System.Windows.Forms.CheckBox()
        Me.creationChkBox = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(0, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select file"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.creationChkBox)
        Me.Panel1.Controls.Add(Me.lastwriteChkBox)
        Me.Panel1.Controls.Add(Me.lastaccessChkBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 73)
        Me.Panel1.TabIndex = 2
        '
        'lastaccessChkBox
        '
        Me.lastaccessChkBox.AutoSize = True
        Me.lastaccessChkBox.Location = New System.Drawing.Point(3, 6)
        Me.lastaccessChkBox.Name = "lastaccessChkBox"
        Me.lastaccessChkBox.Size = New System.Drawing.Size(120, 17)
        Me.lastaccessChkBox.TabIndex = 0
        Me.lastaccessChkBox.Text = "Set last access time"
        Me.lastaccessChkBox.UseVisualStyleBackColor = True
        '
        'lastwriteChkBox
        '
        Me.lastwriteChkBox.AutoSize = True
        Me.lastwriteChkBox.Location = New System.Drawing.Point(3, 29)
        Me.lastwriteChkBox.Name = "lastwriteChkBox"
        Me.lastwriteChkBox.Size = New System.Drawing.Size(108, 17)
        Me.lastwriteChkBox.TabIndex = 1
        Me.lastwriteChkBox.Text = "Set last write time"
        Me.lastwriteChkBox.UseVisualStyleBackColor = True
        '
        'creationChkBox
        '
        Me.creationChkBox.AutoSize = True
        Me.creationChkBox.Location = New System.Drawing.Point(3, 52)
        Me.creationChkBox.Name = "creationChkBox"
        Me.creationChkBox.Size = New System.Drawing.Size(105, 17)
        Me.creationChkBox.TabIndex = 2
        Me.creationChkBox.Text = "Set creation time"
        Me.creationChkBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(140, 116)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(156, 155)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(156, 155)
        Me.Name = "Form1"
        Me.Text = "Backdater"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents creationChkBox As CheckBox
    Friend WithEvents lastwriteChkBox As CheckBox
    Friend WithEvents lastaccessChkBox As CheckBox
End Class
