Imports System.Data.SqlClient
Public Class frmProductType

    Dim connect As New SqlConnection
    Dim command As New SqlCommand
    Dim dr As SqlDataReader
    Dim connectstring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\miniProjectDB.mdf;Integrated Security=True"

    Private Sub frmProductType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect = New SqlConnection(connectstring)
        connect.Open()

        Call showDGData()
    End Sub

    Private Sub showDGData()
        Dim sqlcon As String = "SELECT * FROM ProductType"
        command = New SqlCommand(sqlcon, connect)
        dr = command.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGProductType.DataSource = dt
        DGProductType.Columns(0).HeaderText = "ລະຫັດປະເພດ"
        DGProductType.Columns(1).HeaderText = "ຊື່ປະເພດສິນຄ້າ"

        'DGProductType.Columns(0).Width = 500
        'DGProductType.Columns(1).Width = 500
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sqlInsert As String = "INSERT INTO ProductType VALUES('" + txtPtID.Text + "', N'" & txtPtName.Text & "')"
        command = New SqlCommand(sqlInsert, connect)
        command.ExecuteNonQuery()
        Call showDGData()
        txtPtID.Text = ""
        txtPtName.Text = ""
    End Sub

    Private Sub DGProductType_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGProductType.CellMouseClick
        Dim cindex As Integer = DGProductType.CurrentRow.Index
        txtPtID.Text = DGProductType.Item(0, cindex).Value.ToString
        txtPtName.Text = DGProductType.Item(1, cindex).Value.ToString
    End Sub

    Private Sub brnDelete_Click(sender As Object, e As EventArgs) Handles brnDelete.Click
        Dim sqlInsert As String = "DELETE FROM ProductType WHERE ProductType_ID='" + txtPtID.Text + "'"
        command = New SqlCommand(sqlInsert, connect)
        command.ExecuteNonQuery()
        Call showDGData()
        txtPtID.Text = ""
        txtPtName.Text = ""
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim sqlInsert As String = "UPDATE ProductType SET ProductType_Name=N'" + txtPtName.Text + "' WHERE ProductType_ID='" + txtPtID.Text + "'"
        command = New SqlCommand(sqlInsert, connect)
        command.ExecuteNonQuery()
        Call showDGData()
        txtPtID.Text = ""
        txtPtName.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class