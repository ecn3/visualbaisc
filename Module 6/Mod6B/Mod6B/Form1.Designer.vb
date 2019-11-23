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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddRainFall = New System.Windows.Forms.Button()
        Me.lstRainFall = New System.Windows.Forms.ListBox()
        Me.lblAverageRainFall = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'btnAddRainFall
        '
        Me.btnAddRainFall.Location = New System.Drawing.Point(12, 27)
        Me.btnAddRainFall.Name = "btnAddRainFall"
        Me.btnAddRainFall.Size = New System.Drawing.Size(75, 23)
        Me.btnAddRainFall.TabIndex = 1
        Me.btnAddRainFall.Text = "Add Rainfall"
        Me.btnAddRainFall.UseVisualStyleBackColor = True
        '
        'lstRainFall
        '
        Me.lstRainFall.FormattingEnabled = True
        Me.lstRainFall.Location = New System.Drawing.Point(12, 56)
        Me.lstRainFall.Name = "lstRainFall"
        Me.lstRainFall.Size = New System.Drawing.Size(75, 225)
        Me.lstRainFall.TabIndex = 2
        '
        'lblAverageRainFall
        '
        Me.lblAverageRainFall.AutoSize = True
        Me.lblAverageRainFall.Location = New System.Drawing.Point(13, 288)
        Me.lblAverageRainFall.Name = "lblAverageRainFall"
        Me.lblAverageRainFall.Size = New System.Drawing.Size(88, 13)
        Me.lblAverageRainFall.TabIndex = 3
        Me.lblAverageRainFall.Text = "Average RainFall"
        Me.lblAverageRainFall.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mod6B.My.Resources.Resources.hawoo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAverageRainFall)
        Me.Controls.Add(Me.lstRainFall)
        Me.Controls.Add(Me.btnAddRainFall)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Most Rainfall in the USA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents btnAddRainFall As Button
    Friend WithEvents lstRainFall As ListBox
    Friend WithEvents lblAverageRainFall As Label
End Class
