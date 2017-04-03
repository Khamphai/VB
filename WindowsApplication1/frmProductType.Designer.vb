<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductType
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGProductType = New System.Windows.Forms.DataGridView()
        Me.lblPtID = New System.Windows.Forms.Label()
        Me.txtPtID = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblPtName = New System.Windows.Forms.Label()
        Me.txtPtName = New System.Windows.Forms.TextBox()
        Me.brnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.DGProductType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGProductType
        '
        Me.DGProductType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGProductType.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProductType.Location = New System.Drawing.Point(13, 105)
        Me.DGProductType.Name = "DGProductType"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGProductType.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGProductType.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGProductType.Size = New System.Drawing.Size(543, 290)
        Me.DGProductType.TabIndex = 0
        '
        'lblPtID
        '
        Me.lblPtID.AutoSize = True
        Me.lblPtID.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtID.Location = New System.Drawing.Point(55, 17)
        Me.lblPtID.Name = "lblPtID"
        Me.lblPtID.Size = New System.Drawing.Size(128, 26)
        Me.lblPtID.TabIndex = 1
        Me.lblPtID.Text = "ລະຫັດປະເພດ:"
        '
        'txtPtID
        '
        Me.txtPtID.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtID.Location = New System.Drawing.Point(197, 12)
        Me.txtPtID.Name = "txtPtID"
        Me.txtPtID.Size = New System.Drawing.Size(359, 33)
        Me.txtPtID.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(576, 106)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 66)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "ເພີ່ມຂໍ້ມູນ"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblPtName
        '
        Me.lblPtName.AutoSize = True
        Me.lblPtName.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtName.Location = New System.Drawing.Point(47, 65)
        Me.lblPtName.Name = "lblPtName"
        Me.lblPtName.Size = New System.Drawing.Size(136, 26)
        Me.lblPtName.TabIndex = 4
        Me.lblPtName.Text = "ຊື່ປະເພດສິນຄ້າ:"
        '
        'txtPtName
        '
        Me.txtPtName.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtName.Location = New System.Drawing.Point(197, 58)
        Me.txtPtName.Name = "txtPtName"
        Me.txtPtName.Size = New System.Drawing.Size(359, 33)
        Me.txtPtName.TabIndex = 5
        '
        'brnDelete
        '
        Me.brnDelete.BackColor = System.Drawing.Color.Transparent
        Me.brnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brnDelete.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnDelete.Location = New System.Drawing.Point(576, 250)
        Me.brnDelete.Name = "brnDelete"
        Me.brnDelete.Size = New System.Drawing.Size(138, 66)
        Me.brnDelete.TabIndex = 6
        Me.brnDelete.Text = "ລົບຂໍ້ມູນ"
        Me.brnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(576, 178)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(138, 66)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "ແກ້ໄຂຂໍ້ມູນ"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Noto Serif Lao", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(576, 329)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 66)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "ປິດໂປຣແກຣມ"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmProductType
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(726, 404)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.brnDelete)
        Me.Controls.Add(Me.txtPtName)
        Me.Controls.Add(Me.lblPtName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtPtID)
        Me.Controls.Add(Me.lblPtID)
        Me.Controls.Add(Me.DGProductType)
        Me.Name = "frmProductType"
        Me.Text = "frmProductType"
        CType(Me.DGProductType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGProductType As DataGridView
    Friend WithEvents lblPtID As Label
    Friend WithEvents txtPtID As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblPtName As Label
    Friend WithEvents txtPtName As TextBox
    Friend WithEvents brnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClose As Button
End Class
