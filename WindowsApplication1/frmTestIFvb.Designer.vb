<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestIFvb
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
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.Teal
        Me.Lbl1.Location = New System.Drawing.Point(127, 54)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(212, 26)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "ກະລຸນາປ້ອນອາຍຸຂອງທ່ານ"
        '
        'Txt1
        '
        Me.Txt1.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt1.Location = New System.Drawing.Point(98, 109)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(273, 33)
        Me.Txt1.TabIndex = 1
        Me.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.ForeColor = System.Drawing.Color.Teal
        Me.Btn1.Location = New System.Drawing.Point(98, 236)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(275, 55)
        Me.Btn1.TabIndex = 2
        Me.Btn1.Text = "ກວດສອບ"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Lbl2
        '
        Me.Lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbl2.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.ForeColor = System.Drawing.Color.Teal
        Me.Lbl2.Location = New System.Drawing.Point(95, 175)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(278, 26)
        Me.Lbl2.TabIndex = 3
        Me.Lbl2.Text = "ຜົນການກວດສອບ"
        Me.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTestIFvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 350)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lbl1)
        Me.Name = "frmTestIFvb"
        Me.Text = "frmTestIFvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl1 As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Btn1 As Button
    Friend WithEvents Lbl2 As Label
End Class
