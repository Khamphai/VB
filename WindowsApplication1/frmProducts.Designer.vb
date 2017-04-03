<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.DGProducts = New System.Windows.Forms.DataGridView()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtInstock = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.cmbUnits = New System.Windows.Forms.ComboBox()
        Me.cmbProductType = New System.Windows.Forms.ComboBox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblPtType = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.PcbProduct = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGProducts
        '
        Me.DGProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProducts.Location = New System.Drawing.Point(12, 319)
        Me.DGProducts.Name = "DGProducts"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Phetsarath OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGProducts.Size = New System.Drawing.Size(838, 204)
        Me.DGProducts.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(39, 81)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(93, 22)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ລະຫັດສິນຄ້າ"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(138, 74)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(233, 29)
        Me.txtID.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(138, 109)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(233, 29)
        Me.txtName.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(67, 116)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 22)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "ຊື່ສິນຄ້າ"
        '
        'txtInstock
        '
        Me.txtInstock.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstock.Location = New System.Drawing.Point(138, 144)
        Me.txtInstock.Name = "txtInstock"
        Me.txtInstock.Size = New System.Drawing.Size(233, 29)
        Me.txtInstock.TabIndex = 6
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(39, 151)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(100, 22)
        Me.lblAmount.TabIndex = 5
        Me.lblAmount.Text = "ຈຳນວນສິນຄ້າ"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(138, 179)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(233, 29)
        Me.txtPrice.TabIndex = 8
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(45, 186)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(87, 22)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "ລາຄາສິນຄ້າ"
        '
        'cmbUnits
        '
        Me.cmbUnits.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnits.FormattingEnabled = True
        Me.cmbUnits.Location = New System.Drawing.Point(138, 227)
        Me.cmbUnits.Name = "cmbUnits"
        Me.cmbUnits.Size = New System.Drawing.Size(233, 30)
        Me.cmbUnits.TabIndex = 9
        '
        'cmbProductType
        '
        Me.cmbProductType.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductType.FormattingEnabled = True
        Me.cmbProductType.Location = New System.Drawing.Point(138, 271)
        Me.cmbProductType.Name = "cmbProductType"
        Me.cmbProductType.Size = New System.Drawing.Size(233, 30)
        Me.cmbProductType.TabIndex = 10
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(20, 233)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(112, 22)
        Me.lblUnit.TabIndex = 11
        Me.lblUnit.Text = "ຫົວໜ່ວຍສິນຄ້າ"
        '
        'lblPtType
        '
        Me.lblPtType.AutoSize = True
        Me.lblPtType.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtType.Location = New System.Drawing.Point(33, 277)
        Me.lblPtType.Name = "lblPtType"
        Me.lblPtType.Size = New System.Drawing.Size(99, 22)
        Me.lblPtType.TabIndex = 12
        Me.lblPtType.Text = "ປະເພດສິນຄ້າ"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(693, 71)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 31)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "ເພີ່ມຂໍ້ມູນ"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(693, 128)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(114, 29)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "ແກ້ໄຂ"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(693, 183)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 28)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "ບັນທຶກ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(693, 271)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 30)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "ລົບຂໍ້ມູນ"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnChooseImage
        '
        Me.btnChooseImage.Font = New System.Drawing.Font("Noto Serif Lao", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseImage.Location = New System.Drawing.Point(506, 273)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(115, 31)
        Me.btnChooseImage.TabIndex = 17
        Me.btnChooseImage.Text = "ເລືອກຮູບພາບ"
        Me.btnChooseImage.UseVisualStyleBackColor = True
        '
        'PcbProduct
        '
        Me.PcbProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PcbProduct.Location = New System.Drawing.Point(468, 74)
        Me.PcbProduct.Name = "PcbProduct"
        Me.PcbProduct.Size = New System.Drawing.Size(188, 181)
        Me.PcbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbProduct.TabIndex = 18
        Me.PcbProduct.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Noto Serif Lao", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(372, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 34)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "ຈັດການສິນຄ້າ"
        '
        'frmProducts
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(863, 537)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PcbProduct)
        Me.Controls.Add(Me.btnChooseImage)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblPtType)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.cmbProductType)
        Me.Controls.Add(Me.cmbUnits)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtInstock)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.DGProducts)
        Me.Name = "frmProducts"
        Me.Text = "frmProducts"
        CType(Me.DGProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGProducts As DataGridView
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtInstock As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents cmbUnits As ComboBox
    Friend WithEvents cmbProductType As ComboBox
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblPtType As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnChooseImage As Button
    Friend WithEvents PcbProduct As PictureBox
    Friend WithEvents Label7 As Label
End Class
