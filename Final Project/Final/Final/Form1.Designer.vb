﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.changeColorBtn = New System.Windows.Forms.Button()
        Me.changeThemeBtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'changeColorBtn
        '
        Me.changeColorBtn.Location = New System.Drawing.Point(29, 33)
        Me.changeColorBtn.Name = "changeColorBtn"
        Me.changeColorBtn.Size = New System.Drawing.Size(75, 23)
        Me.changeColorBtn.TabIndex = 1
        Me.changeColorBtn.Text = "Color"
        Me.changeColorBtn.UseVisualStyleBackColor = True
        '
        'changeThemeBtn
        '
        Me.changeThemeBtn.Location = New System.Drawing.Point(29, 62)
        Me.changeThemeBtn.Name = "changeThemeBtn"
        Me.changeThemeBtn.Size = New System.Drawing.Size(75, 23)
        Me.changeThemeBtn.TabIndex = 2
        Me.changeThemeBtn.Text = "Themes"
        Me.changeThemeBtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(29, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Style"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(29, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Purchase"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        '
        'pic
        '
        Me.pic.Image = Global.Final.My.Resources.Resources.plainYellowDuck
        Me.pic.Location = New System.Drawing.Point(389, 33)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(337, 282)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.changeThemeBtn)
        Me.Controls.Add(Me.changeColorBtn)
        Me.Controls.Add(Me.pic)
        Me.Name = "Form1"
        Me.Text = "Choose a duck"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic As PictureBox
    Friend WithEvents changeColorBtn As Button
    Friend WithEvents changeThemeBtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label1 As Label
End Class
