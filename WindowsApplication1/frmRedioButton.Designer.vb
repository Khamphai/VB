<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRedioButton
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
        Me.components = New System.ComponentModel.Container()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.Rad1 = New System.Windows.Forms.RadioButton()
        Me.Rad2 = New System.Windows.Forms.RadioButton()
        Me.Rad3 = New System.Windows.Forms.RadioButton()
        Me.Rad4 = New System.Windows.Forms.RadioButton()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Rad5 = New System.Windows.Forms.RadioButton()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic1
        '
        Me.Pic1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic1.Location = New System.Drawing.Point(263, 29)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(436, 403)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic1.TabIndex = 0
        Me.Pic1.TabStop = False
        '
        'Rad1
        '
        Me.Rad1.AutoSize = True
        Me.Rad1.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Rad1.Location = New System.Drawing.Point(77, 59)
        Me.Rad1.Name = "Rad1"
        Me.Rad1.Size = New System.Drawing.Size(124, 30)
        Me.Rad1.TabIndex = 1
        Me.Rad1.TabStop = True
        Me.Rad1.Text = "ຮູບພາບທີ 1"
        Me.Rad1.UseVisualStyleBackColor = True
        '
        'Rad2
        '
        Me.Rad2.AutoSize = True
        Me.Rad2.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Rad2.Location = New System.Drawing.Point(77, 109)
        Me.Rad2.Name = "Rad2"
        Me.Rad2.Size = New System.Drawing.Size(124, 30)
        Me.Rad2.TabIndex = 2
        Me.Rad2.TabStop = True
        Me.Rad2.Text = "ຮູບພາບທີ 2"
        Me.Rad2.UseVisualStyleBackColor = True
        '
        'Rad3
        '
        Me.Rad3.AutoSize = True
        Me.Rad3.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Rad3.Location = New System.Drawing.Point(77, 163)
        Me.Rad3.Name = "Rad3"
        Me.Rad3.Size = New System.Drawing.Size(124, 30)
        Me.Rad3.TabIndex = 3
        Me.Rad3.TabStop = True
        Me.Rad3.Text = "ຮູບພາບທີ 3"
        Me.Rad3.UseVisualStyleBackColor = True
        '
        'Rad4
        '
        Me.Rad4.AutoSize = True
        Me.Rad4.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Rad4.Location = New System.Drawing.Point(77, 217)
        Me.Rad4.Name = "Rad4"
        Me.Rad4.Size = New System.Drawing.Size(124, 30)
        Me.Rad4.TabIndex = 4
        Me.Rad4.TabStop = True
        Me.Rad4.Text = "ຮູບພາບທີ 4"
        Me.Rad4.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Noto Serif Lao", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(77, 326)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(110, 50)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStop.Font = New System.Drawing.Font("Noto Serif Lao", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(77, 382)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(110, 50)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Rad5
        '
        Me.Rad5.AutoSize = True
        Me.Rad5.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Rad5.Location = New System.Drawing.Point(77, 270)
        Me.Rad5.Name = "Rad5"
        Me.Rad5.Size = New System.Drawing.Size(124, 30)
        Me.Rad5.TabIndex = 7
        Me.Rad5.TabStop = True
        Me.Rad5.Text = "ຮູບພາບທີ 5"
        Me.Rad5.UseVisualStyleBackColor = True
        '
        'frmRedioButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 477)
        Me.Controls.Add(Me.Rad5)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Rad4)
        Me.Controls.Add(Me.Rad3)
        Me.Controls.Add(Me.Rad2)
        Me.Controls.Add(Me.Rad1)
        Me.Controls.Add(Me.Pic1)
        Me.Name = "frmRedioButton"
        Me.Text = "frmRedioButton"
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pic1 As PictureBox
    Friend WithEvents Rad1 As RadioButton
    Friend WithEvents Rad2 As RadioButton
    Friend WithEvents Rad3 As RadioButton
    Friend WithEvents Rad4 As RadioButton
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Rad5 As RadioButton
End Class
