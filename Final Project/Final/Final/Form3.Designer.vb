<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numDucksUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.themeLbl = New System.Windows.Forms.Label()
        Me.skinColorLbl = New System.Windows.Forms.Label()
        Me.priceLbl = New System.Windows.Forms.Label()
        Me.buyBtn = New System.Windows.Forms.Button()
        CType(Me.numDucksUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Duck(s)"
        '
        'numDucksUpDown
        '
        Me.numDucksUpDown.Location = New System.Drawing.Point(85, 11)
        Me.numDucksUpDown.Name = "numDucksUpDown"
        Me.numDucksUpDown.Size = New System.Drawing.Size(56, 20)
        Me.numDucksUpDown.TabIndex = 1
        Me.numDucksUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Theme:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Skin Color:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Price: $"
        '
        'themeLbl
        '
        Me.themeLbl.AutoSize = True
        Me.themeLbl.Location = New System.Drawing.Point(103, 38)
        Me.themeLbl.Name = "themeLbl"
        Me.themeLbl.Size = New System.Drawing.Size(50, 13)
        Me.themeLbl.TabIndex = 5
        Me.themeLbl.Text = "themeLbl"
        '
        'skinColorLbl
        '
        Me.skinColorLbl.AutoSize = True
        Me.skinColorLbl.Location = New System.Drawing.Point(103, 62)
        Me.skinColorLbl.Name = "skinColorLbl"
        Me.skinColorLbl.Size = New System.Drawing.Size(40, 13)
        Me.skinColorLbl.TabIndex = 6
        Me.skinColorLbl.Text = "skinLbl"
        '
        'priceLbl
        '
        Me.priceLbl.AutoSize = True
        Me.priceLbl.Location = New System.Drawing.Point(103, 87)
        Me.priceLbl.Name = "priceLbl"
        Me.priceLbl.Size = New System.Drawing.Size(44, 13)
        Me.priceLbl.TabIndex = 7
        Me.priceLbl.Text = "priceLbl"
        '
        'buyBtn
        '
        Me.buyBtn.Location = New System.Drawing.Point(38, 122)
        Me.buyBtn.Name = "buyBtn"
        Me.buyBtn.Size = New System.Drawing.Size(105, 23)
        Me.buyBtn.TabIndex = 8
        Me.buyBtn.Text = "Buy"
        Me.buyBtn.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buyBtn)
        Me.Controls.Add(Me.priceLbl)
        Me.Controls.Add(Me.skinColorLbl)
        Me.Controls.Add(Me.themeLbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numDucksUpDown)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Purchase Screen"
        CType(Me.numDucksUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numDucksUpDown As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents themeLbl As Label
    Friend WithEvents skinColorLbl As Label
    Friend WithEvents priceLbl As Label
    Friend WithEvents buyBtn As Button
End Class
