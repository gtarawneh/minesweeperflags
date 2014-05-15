<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Border = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowMinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BeginnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GameMode1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GameMode2 = New System.Windows.Forms.ToolStripMenuItem
        Me.GameMode3 = New System.Windows.Forms.ToolStripMenuItem
        Me.PlaySoundsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.HighScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HowToPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.RemainingMinesLbl = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SweepsLbl = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Border
        '
        Me.Border.Location = New System.Drawing.Point(12, 72)
        Me.Border.Name = "Border"
        Me.Border.Size = New System.Drawing.Size(466, 471)
        Me.Border.TabIndex = 3
        Me.Border.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(491, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem1
        '
        Me.GameToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ShowMinesToolStripMenuItem, Me.ToolStripSeparator4, Me.BeginnerToolStripMenuItem, Me.PlaySoundsToolStripMenuItem, Me.ToolStripSeparator2, Me.HighScoresToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.GameToolStripMenuItem1.Name = "GameToolStripMenuItem1"
        Me.GameToolStripMenuItem1.Size = New System.Drawing.Size(46, 20)
        Me.GameToolStripMenuItem1.Text = "&Game"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Image = CType(resources.GetObject("NewGameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.ShortcutKeyDisplayString = "F2"
        Me.NewGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NewGameToolStripMenuItem.Text = "&New Game"
        '
        'ShowMinesToolStripMenuItem
        '
        Me.ShowMinesToolStripMenuItem.Image = CType(resources.GetObject("ShowMinesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowMinesToolStripMenuItem.Name = "ShowMinesToolStripMenuItem"
        Me.ShowMinesToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ShowMinesToolStripMenuItem.Text = "&Show Mines"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'BeginnerToolStripMenuItem
        '
        Me.BeginnerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameMode1, Me.GameMode2, Me.GameMode3})
        Me.BeginnerToolStripMenuItem.Image = CType(resources.GetObject("BeginnerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BeginnerToolStripMenuItem.Name = "BeginnerToolStripMenuItem"
        Me.BeginnerToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BeginnerToolStripMenuItem.Text = "Game Mode"
        '
        'GameMode1
        '
        Me.GameMode1.Name = "GameMode1"
        Me.GameMode1.Size = New System.Drawing.Size(189, 22)
        Me.GameMode1.Text = "Beginner (25 Mines)"
        '
        'GameMode2
        '
        Me.GameMode2.Name = "GameMode2"
        Me.GameMode2.Size = New System.Drawing.Size(189, 22)
        Me.GameMode2.Text = "Intermediate (30 Mines)"
        '
        'GameMode3
        '
        Me.GameMode3.Name = "GameMode3"
        Me.GameMode3.Size = New System.Drawing.Size(189, 22)
        Me.GameMode3.Text = "Expert (35 Mines)"
        '
        'PlaySoundsToolStripMenuItem
        '
        Me.PlaySoundsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnabledToolStripMenuItem, Me.DisabledToolStripMenuItem})
        Me.PlaySoundsToolStripMenuItem.Image = CType(resources.GetObject("PlaySoundsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PlaySoundsToolStripMenuItem.Name = "PlaySoundsToolStripMenuItem"
        Me.PlaySoundsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PlaySoundsToolStripMenuItem.Text = "Game Sounds"
        '
        'EnabledToolStripMenuItem
        '
        Me.EnabledToolStripMenuItem.Name = "EnabledToolStripMenuItem"
        Me.EnabledToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.EnabledToolStripMenuItem.Text = "On"
        '
        'DisabledToolStripMenuItem
        '
        Me.DisabledToolStripMenuItem.Name = "DisabledToolStripMenuItem"
        Me.DisabledToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.DisabledToolStripMenuItem.Text = "Off"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(141, 6)
        '
        'HighScoresToolStripMenuItem
        '
        Me.HighScoresToolStripMenuItem.Image = CType(resources.GetObject("HighScoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HighScoresToolStripMenuItem.Name = "HighScoresToolStripMenuItem"
        Me.HighScoresToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.HighScoresToolStripMenuItem.Text = "&High Scores"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToPlayToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem1.Text = "&Help"
        '
        'HowToPlayToolStripMenuItem
        '
        Me.HowToPlayToolStripMenuItem.Image = CType(resources.GetObject("HowToPlayToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HowToPlayToolStripMenuItem.Name = "HowToPlayToolStripMenuItem"
        Me.HowToPlayToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.HowToPlayToolStripMenuItem.Text = "&How To Play"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.RemainingMinesLbl, Me.ToolStripSeparator3, Me.SweepsLbl, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(3)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(491, 42)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton1.Size = New System.Drawing.Size(33, 33)
        Me.ToolStripButton1.Text = "New Game"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Padding = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton2.Size = New System.Drawing.Size(33, 33)
        Me.ToolStripButton2.Text = "Show Mines"
        '
        'RemainingMinesLbl
        '
        Me.RemainingMinesLbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RemainingMinesLbl.Name = "RemainingMinesLbl"
        Me.RemainingMinesLbl.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.RemainingMinesLbl.Size = New System.Drawing.Size(125, 33)
        Me.RemainingMinesLbl.Text = "Remaining Mines: 40"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 36)
        '
        'SweepsLbl
        '
        Me.SweepsLbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SweepsLbl.Name = "SweepsLbl"
        Me.SweepsLbl.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.SweepsLbl.Size = New System.Drawing.Size(80, 33)
        Me.SweepsLbl.Text = "Sweeps : 0"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Padding = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton3.Size = New System.Drawing.Size(33, 33)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "How To Play"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(491, 556)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Border)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minesweeper Flags"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Border As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemainingMinesLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SweepsLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BeginnerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameMode1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameMode2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameMode3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaySoundsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnabledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisabledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighScoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToPlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton

End Class
