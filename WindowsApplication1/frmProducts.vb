Imports System.Data.SqlClient
Imports System.IO
Public Class frmProducts

    Dim filenamedata As String
    Dim imageDir As String

    Dim connect As New SqlConnection
    Dim command As New SqlCommand
    Dim dr As SqlDataReader
    Dim connectstring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\miniProjectDB.mdf;Integrated Security=True"

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect = New SqlConnection(connectstring)
        connect.Open()

        Dim dtPt As New DataTable
        command = New SqlCommand("SELECT * FROM ProductType", connect)
        dr = command.ExecuteReader()
        dtPt.Load(dr)
        cmbProductType.DataSource = dtPt
        cmbProductType.DisplayMember = "ProductType_Name"
        cmbProductType.ValueMember = "ProductType_ID"

        Dim dtUnit As New DataTable
        command = New SqlCommand("SELECT unitID, unitName FROM tblUnits", connect)
        dr = command.ExecuteReader()
        dtUnit.Load(dr)
        cmbUnits.DataSource = dtUnit
        cmbUnits.DisplayMember = "unitName"
        cmbUnits.ValueMember = "unitID"

        Call showData()
    End Sub

    Private Sub showData()
        Dim sqlSelect As String = "SELECT * FROM Products"
        command = New SqlCommand(sqlSelect, connect)
        dr = command.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGProducts.DataSource = dt
        DGProducts.Columns(0).HeaderText = "ລະຫັດສິນຄ້າ"
        DGProducts.Columns(1).HeaderText = "ຊື່ສິນຄ້າ"
        DGProducts.Columns(2).HeaderText = "ຈຳນວນສິນຄ້າ"
        DGProducts.Columns(3).HeaderText = "ລາຄາສິນຄ້າ"
        DGProducts.Columns(4).HeaderText = "ຮູບພາຍສິນຄ້າ"
        DGProducts.Columns(5).HeaderText = "ຫົວໜ່ວຍສິນຄ້າ"
        DGProducts.Columns(6).HeaderText = "ປະເພດສິນຄ້າ"
    End Sub

    Private Sub Doing(sql As String)
        command = New SqlCommand(sql, connect)
        command.ExecuteNonQuery()
        Call showData()
        Call Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim imagefile As String
        imagefile = CInt(Int(100 * Rnd()) + 1) & filenamedata
        Dim sqlInsert As String = "INSERT INTO Products VALUES('" + txtID.Text + "',
                                                                N'" + txtName.Text + "', 
                                                                '" + txtInstock.Text + "',
                                                                '" + txtPrice.Text + "', 
                                                                '" + imagefile + "', 
                                                                '" + cmbUnits.SelectedValue.ToString + "', 
                                                                '" + cmbProductType.SelectedValue.ToString + "')"
        Call Doing(sqlInsert)
        'Save
        Dim dirfile As String
        dirfile = Application.StartupPath & "\images\" & imagefile
        File.Copy(imageDir, dirfile)

    End Sub

    Private Sub DGProducts_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGProducts.CellMouseClick
        Dim cindex As Integer = DGProducts.CurrentRow.Index
        txtID.Text = DGProducts.Item(0, cindex).Value.ToString
        txtName.Text = DGProducts.Item(1, cindex).Value.ToString
        txtInstock.Text = DGProducts.Item(2, cindex).Value.ToString
        txtPrice.Text = DGProducts.Item(3, cindex).Value.ToString
        cmbUnits.SelectedValue = DGProducts.Item(5, cindex).Value.ToString
        cmbProductType.SelectedValue = DGProducts.Item(6, cindex).Value.ToString
        Try
            filenamedata = DGProducts.Item(4, cindex).Value.ToString
            PcbProduct.Image = Image.FromFile(Application.StartupPath & "\images\" & filenamedata)
        Catch ex As Exception
            PcbProduct.Image = PcbProduct.ErrorImage
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Dim imagefile As String
        'imagefile = CInt(Int(100 * Rnd()) + 1) & filenamedata
        Dim sqlUpdate As String = "UPDATE Products SET 
                                                        Pro_Name=N'" + txtName.Text + "',
                                                        Instock='" + txtInstock.Text + "',
                                                        UnitPrice='" + txtPrice.Text + "',                                                   
                                                        UnitID='" + cmbUnits.SelectedValue.ToString + "',
                                                        ProductType_ID='" + cmbProductType.SelectedValue.ToString + "' 
                                                        WHERE Pro_ID='" + txtID.Text + "'"
        Call Doing(sqlUpdate)
        'Save
        'Dim dirfile As String
        'dirfile = Application.StartupPath & "\images\" & imagefile
        'File.Copy(imageDir, dirfile)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you want to Delete it", "Question ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim sqlDelete As String = "DELETE FROM Products WHERE Pro_ID='" + txtID.Text + "'"
            Call Doing(sqlDelete)
        End If
    End Sub

    Private Sub Clear()
        txtID.Text = ""
        txtName.Text = ""
        txtInstock.Text = ""
        txtPrice.Text = ""

        Dim dtPt As New DataTable
        command = New SqlCommand("SELECT * FROM ProductType", connect)
        dr = command.ExecuteReader()
        dtPt.Load(dr)
        cmbProductType.DataSource = dtPt
        cmbProductType.DisplayMember = "ProductType_Name"
        cmbProductType.ValueMember = "ProductType_ID"

        Dim dtUnit As New DataTable
        command = New SqlCommand("SELECT unitID, unitName FROM tblUnits", connect)
        dr = command.ExecuteReader()
        dtUnit.Load(dr)
        cmbUnits.DataSource = dtUnit
        cmbUnits.DisplayMember = "unitName"
        cmbUnits.ValueMember = "unitID"
    End Sub

    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        Dim ofd As New OpenFileDialog
        ofd.FileName = String.Empty
        ofd.ShowDialog()
        If ofd.FileName = String.Empty Then
            Return
        End If
        PcbProduct.Image = Image.FromFile(ofd.FileName)
        imageDir = ofd.FileName
        filenamedata = Mid(ofd.FileName, InStrRev(ofd.FileName, "\", Len(ofd.FileName)) + 1)
    End Sub


End Class