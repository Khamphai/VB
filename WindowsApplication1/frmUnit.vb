Imports System.Data.SqlClient
Public Class frmUnit

    Dim connect As New SqlConnection
    Dim command As New SqlCommand
    Dim dr As SqlDataReader
    Dim connectstring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\miniProjectDB.mdf;Integrated Security=True"

    Private Sub frmUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect = New SqlConnection(connectstring)
        connect.Open()

        Call showDGUnit()
    End Sub

    Private Sub showDGUnit()
        Dim sqlSelect As String = "SELECT * FROM tblUnits"
        command = New SqlCommand(sqlSelect, connect)
        dr = command.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGUnit.DataSource = dt
        DGUnit.Columns(0).HeaderText = "ລະຫັດຫົວໝ່ວຍ"
        DGUnit.Columns(1).HeaderText = "ຊື່ຫົວໝ່ວຍ"
        DGUnit.Columns(2).HeaderText = "ຄຳອະທິບາຍ"
    End Sub

    Private Sub Doing(sql As String)
        command = New SqlCommand(sql, connect)
        command.ExecuteNonQuery()
        Call showDGUnit()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sqlInsert As String = "INSERT INTO tblUnits VALUES('" + txtUnitID.Text + "', N'" & txtUnitName.Text & "', N'" & txtUnitDes.Text & "')"
        Call Doing(sqlInsert)
        txtUnitID.Text = ""
        txtUnitName.Text = ""
        txtUnitDes.Text = ""
    End Sub

    Private Sub DGUnit_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGUnit.CellMouseClick
        Dim cindex As Integer = DGUnit.CurrentRow.Index
        txtUnitID.Text = DGUnit.Item(0, cindex).Value.ToString
        txtUnitName.Text = DGUnit.Item(1, cindex).Value.ToString
        txtUnitDes.Text = DGUnit.Item(2, cindex).Value.ToString
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim sqlUpdate As String = "UPDATE tblUnits SET unitName=N'" + txtUnitName.Text + "', description=N'" + txtUnitDes.Text + "' WHERE unitID='" + txtUnitID.Text + "'"
        Call Doing(sqlUpdate)
        txtUnitID.Text = ""
        txtUnitName.Text = ""
        txtUnitDes.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sqlDelete As String = "DELETE FROM tblUnits WHERE unitID='" + txtUnitID.Text + "'"
        Call Doing(sqlDelete)
        txtUnitID.Text = ""
        txtUnitName.Text = ""
        txtUnitDes.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class