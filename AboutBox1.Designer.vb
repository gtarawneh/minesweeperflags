<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class AboutBox1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox1))
        Me.LabelProductName = New System.Windows.Forms.Label
        Me.LabelCopyright = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(153, 30)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(134, 13)
        Me.LabelProductName.TabIndex = 9
        Me.LabelProductName.Text = "Minesweeper Flags 1.0"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCopyright.Location = New System.Drawing.Point(153, 54)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelCopyright.Size = New System.Drawing.Size(102, 13)
        Me.LabelCopyright.TabIndex = 10
        Me.LabelCopyright.Text = "Ghaith Z. Tarawneh"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(260, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 29)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&Ok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Gtarawneh@hotmail.com"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(128, 128)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LogoPictureBox.TabIndex = 1
        Me.LogoPictureBox.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(153, 102)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(149, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://extruder.blogspot.com"
        '
        'AboutBox1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(369, 184)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox1"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
