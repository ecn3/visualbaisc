<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDecking
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSquareFeet = New System.Windows.Forms.Label()
        Me.txtFootage = New System.Windows.Forms.TextBox()
        Me.grpDeckType = New System.Windows.Forms.GroupBox()
        Me.radLumber = New System.Windows.Forms.RadioButton()
        Me.radComposite = New System.Windows.Forms.RadioButton()
        Me.radRedwood = New System.Windows.Forms.RadioButton()
        Me.grpDeckType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AccessibleName = "lblHeading"
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(27, 13)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(337, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Decking Cost Calculator"
        '
        'lblSquareFeet
        '
        Me.lblSquareFeet.AutoSize = True
        Me.lblSquareFeet.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquareFeet.Location = New System.Drawing.Point(88, 50)
        Me.lblSquareFeet.Name = "lblSquareFeet"
        Me.lblSquareFeet.Size = New System.Drawing.Size(149, 25)
        Me.lblSquareFeet.TabIndex = 1
        Me.lblSquareFeet.Text = "Square Footage:"
        '
        'txtFootage
        '
        Me.txtFootage.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFootage.Location = New System.Drawing.Point(243, 50)
        Me.txtFootage.Name = "txtFootage"
        Me.txtFootage.Size = New System.Drawing.Size(50, 33)
        Me.txtFootage.TabIndex = 2
        Me.txtFootage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpDeckType
        '
        Me.grpDeckType.BackColor = System.Drawing.Color.AliceBlue
        Me.grpDeckType.Controls.Add(Me.radComposite)
        Me.grpDeckType.Controls.Add(Me.radLumber)
        Me.grpDeckType.Controls.Add(Me.radRedwood)
        Me.grpDeckType.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDeckType.Location = New System.Drawing.Point(93, 89)
        Me.grpDeckType.Name = "grpDeckType"
        Me.grpDeckType.Size = New System.Drawing.Size(244, 106)
        Me.grpDeckType.TabIndex = 3
        Me.grpDeckType.TabStop = False
        Me.grpDeckType.Text = "Deck Type"
        '
        'radLumber
        '
        Me.radLumber.AutoSize = True
        Me.radLumber.Location = New System.Drawing.Point(20, 19)
        Me.radLumber.Name = "radLumber"
        Me.radLumber.Size = New System.Drawing.Size(218, 27)
        Me.radLumber.TabIndex = 0
        Me.radLumber.TabStop = True
        Me.radLumber.Text = "Pressure-Treated Lumber"
        Me.radLumber.UseVisualStyleBackColor = True
        '
        'radComposite
        '
        Me.radComposite.AutoSize = True
        Me.radComposite.Location = New System.Drawing.Point(20, 62)
        Me.radComposite.Name = "radComposite"
        Me.radComposite.Size = New System.Drawing.Size(111, 27)
        Me.radComposite.TabIndex = 1
        Me.radComposite.TabStop = True
        Me.radComposite.Text = "Composite"
        Me.radComposite.UseVisualStyleBackColor = True
        '
        'radRedwood
        '
        Me.radRedwood.AutoSize = True
        Me.radRedwood.Location = New System.Drawing.Point(20, 41)
        Me.radRedwood.Name = "radRedwood"
        Me.radRedwood.Size = New System.Drawing.Size(100, 27)
        Me.radRedwood.TabIndex = 2
        Me.radRedwood.TabStop = True
        Me.radRedwood.Text = "Redwood"
        Me.radRedwood.UseVisualStyleBackColor = True
        '
        'frmDecking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 392)
        Me.Controls.Add(Me.grpDeckType)
        Me.Controls.Add(Me.txtFootage)
        Me.Controls.Add(Me.lblSquareFeet)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmDecking"
        Me.Text = "Decking Cost Calculator"
        Me.grpDeckType.ResumeLayout(False)
        Me.grpDeckType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSquareFeet As Label
    Friend WithEvents txtFootage As TextBox
    Friend WithEvents grpDeckType As GroupBox
    Friend WithEvents radLumber As RadioButton
    Friend WithEvents radRedwood As RadioButton
    Friend WithEvents radComposite As RadioButton
End Class
