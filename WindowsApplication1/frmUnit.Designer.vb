<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnit
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
        Me.lblUnitID = New System.Windows.Forms.Label()
        Me.txtUnitID = New System.Windows.Forms.TextBox()
        Me.txtUnitName = New System.Windows.Forms.TextBox()
        Me.lblUnitName = New System.Windows.Forms.Label()
        Me.txtUnitDes = New System.Windows.Forms.TextBox()
        Me.lblUnitDes = New System.Windows.Forms.Label()
        Me.DGUnit = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.DGUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUnitID
        '
        Me.lblUnitID.AutoSize = True
        Me.lblUnitID.Location = New System.Drawing.Point(19, 32)
        Me.lblUnitID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnitID.Name = "lblUnitID"
        Me.lblUnitID.Size = New System.Drawing.Size(115, 22)
        Me.lblUnitID.TabIndex = 0
        Me.lblUnitID.Text = "ລະຫັດຫົວໝ່ວຍ"
        '
        'txtUnitID
        '
        Me.txtUnitID.Location = New System.Drawing.Point(145, 29)
        Me.txtUnitID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUnitID.Name = "txtUnitID"
        Me.txtUnitID.Size = New System.Drawing.Size(189, 29)
        Me.txtUnitID.TabIndex = 1
        '
        'txtUnitName
        '
        Me.txtUnitName.Location = New System.Drawing.Point(145, 83)
        Me.txtUnitName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Size = New System.Drawing.Size(189, 29)
        Me.txtUnitName.TabIndex = 3
        '
        'lblUnitName
        '
        Me.lblUnitName.AutoSize = True
        Me.lblUnitName.Location = New System.Drawing.Point(19, 86)
        Me.lblUnitName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnitName.Name = "lblUnitName"
        Me.lblUnitName.Size = New System.Drawing.Size(83, 22)
        Me.lblUnitName.TabIndex = 2
        Me.lblUnitName.Text = "ຊື່ຫົວໝ່ວຍ"
        '
        'txtUnitDes
        '
        Me.txtUnitDes.Location = New System.Drawing.Point(145, 137)
        Me.txtUnitDes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUnitDes.Multiline = True
        Me.txtUnitDes.Name = "txtUnitDes"
        Me.txtUnitDes.Size = New System.Drawing.Size(189, 178)
        Me.txtUnitDes.TabIndex = 5
        '
        'lblUnitDes
        '
        Me.lblUnitDes.AutoSize = True
        Me.lblUnitDes.Location = New System.Drawing.Point(19, 137)
        Me.lblUnitDes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnitDes.Name = "lblUnitDes"
        Me.lblUnitDes.Size = New System.Drawing.Size(91, 22)
        Me.lblUnitDes.TabIndex = 4
        Me.lblUnitDes.Text = "ຄຳອະທິບາຍ"
        '
        'DGUnit
        '
        Me.DGUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUnit.Location = New System.Drawing.Point(357, 29)
        Me.DGUnit.Name = "DGUnit"
        Me.DGUnit.Size = New System.Drawing.Size(437, 290)
        Me.DGUnit.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(357, 347)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(97, 65)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "ເພິ່ມຂໍ້ມູນ"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(471, 347)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 65)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "ແກ້ໄຂ"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(581, 347)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 65)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "ລົບຂໍ້ມູນ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(697, 347)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 65)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "ປິດ"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 441)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DGUnit)
        Me.Controls.Add(Me.txtUnitDes)
        Me.Controls.Add(Me.lblUnitDes)
        Me.Controls.Add(Me.txtUnitName)
        Me.Controls.Add(Me.lblUnitName)
        Me.Controls.Add(Me.txtUnitID)
        Me.Controls.Add(Me.lblUnitID)
        Me.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmUnit"
        Me.Text = "frmUnit"
        CType(Me.DGUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnitID As Label
    Friend WithEvents txtUnitID As TextBox
    Friend WithEvents txtUnitName As TextBox
    Friend WithEvents lblUnitName As Label
    Friend WithEvents txtUnitDes As TextBox
    Friend WithEvents lblUnitDes As Label
    Friend WithEvents DGUnit As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
End Class
