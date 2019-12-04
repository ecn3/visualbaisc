<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.spaceBtn = New System.Windows.Forms.Button()
        Me.CowBoyBtn = New System.Windows.Forms.Button()
        Me.turleBtn = New System.Windows.Forms.Button()
        Me.sportBtn = New System.Windows.Forms.Button()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.artBtn = New System.Windows.Forms.Button()
        Me.heroBtn = New System.Windows.Forms.Button()
        Me.politicianDuck = New System.Windows.Forms.Button()
        Me.themeDuck = New System.Windows.Forms.PictureBox()
        CType(Me.themeDuck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spaceBtn
        '
        Me.spaceBtn.Location = New System.Drawing.Point(13, 31)
        Me.spaceBtn.Name = "spaceBtn"
        Me.spaceBtn.Size = New System.Drawing.Size(75, 23)
        Me.spaceBtn.TabIndex = 1
        Me.spaceBtn.Text = "Space"
        Me.spaceBtn.UseVisualStyleBackColor = True
        '
        'CowBoyBtn
        '
        Me.CowBoyBtn.Location = New System.Drawing.Point(13, 60)
        Me.CowBoyBtn.Name = "CowBoyBtn"
        Me.CowBoyBtn.Size = New System.Drawing.Size(75, 23)
        Me.CowBoyBtn.TabIndex = 2
        Me.CowBoyBtn.Text = "Cow Boy"
        Me.CowBoyBtn.UseVisualStyleBackColor = True
        '
        'turleBtn
        '
        Me.turleBtn.Location = New System.Drawing.Point(13, 89)
        Me.turleBtn.Name = "turleBtn"
        Me.turleBtn.Size = New System.Drawing.Size(75, 23)
        Me.turleBtn.TabIndex = 3
        Me.turleBtn.Text = "Turtle"
        Me.turleBtn.UseVisualStyleBackColor = True
        '
        'sportBtn
        '
        Me.sportBtn.Location = New System.Drawing.Point(13, 118)
        Me.sportBtn.Name = "sportBtn"
        Me.sportBtn.Size = New System.Drawing.Size(75, 23)
        Me.sportBtn.TabIndex = 4
        Me.sportBtn.Text = "Sports"
        Me.sportBtn.UseVisualStyleBackColor = True
        '
        'confirmBtn
        '
        Me.confirmBtn.Location = New System.Drawing.Point(13, 233)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(75, 23)
        Me.confirmBtn.TabIndex = 8
        Me.confirmBtn.Text = "Confirm"
        Me.confirmBtn.UseVisualStyleBackColor = True
        '
        'artBtn
        '
        Me.artBtn.Location = New System.Drawing.Point(13, 204)
        Me.artBtn.Name = "artBtn"
        Me.artBtn.Size = New System.Drawing.Size(75, 23)
        Me.artBtn.TabIndex = 7
        Me.artBtn.Text = "Artist"
        Me.artBtn.UseVisualStyleBackColor = True
        '
        'heroBtn
        '
        Me.heroBtn.Location = New System.Drawing.Point(13, 175)
        Me.heroBtn.Name = "heroBtn"
        Me.heroBtn.Size = New System.Drawing.Size(75, 23)
        Me.heroBtn.TabIndex = 6
        Me.heroBtn.Text = "Hero"
        Me.heroBtn.UseVisualStyleBackColor = True
        '
        'politicianDuck
        '
        Me.politicianDuck.Location = New System.Drawing.Point(13, 146)
        Me.politicianDuck.Name = "politicianDuck"
        Me.politicianDuck.Size = New System.Drawing.Size(75, 23)
        Me.politicianDuck.TabIndex = 5
        Me.politicianDuck.Text = "Politician"
        Me.politicianDuck.UseVisualStyleBackColor = True
        '
        'themeDuck
        '
        Me.themeDuck.Image = Global.Final.My.Resources.Resources.plainYellowDuck
        Me.themeDuck.Location = New System.Drawing.Point(442, 31)
        Me.themeDuck.Name = "themeDuck"
        Me.themeDuck.Size = New System.Drawing.Size(329, 291)
        Me.themeDuck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.themeDuck.TabIndex = 0
        Me.themeDuck.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.confirmBtn)
        Me.Controls.Add(Me.artBtn)
        Me.Controls.Add(Me.heroBtn)
        Me.Controls.Add(Me.politicianDuck)
        Me.Controls.Add(Me.sportBtn)
        Me.Controls.Add(Me.turleBtn)
        Me.Controls.Add(Me.CowBoyBtn)
        Me.Controls.Add(Me.spaceBtn)
        Me.Controls.Add(Me.themeDuck)
        Me.Name = "Form2"
        Me.Text = "Theme"
        CType(Me.themeDuck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents themeDuck As PictureBox
    Friend WithEvents spaceBtn As Button
    Friend WithEvents CowBoyBtn As Button
    Friend WithEvents turleBtn As Button
    Friend WithEvents sportBtn As Button
    Friend WithEvents confirmBtn As Button
    Friend WithEvents artBtn As Button
    Friend WithEvents heroBtn As Button
    Friend WithEvents politicianDuck As Button
End Class
