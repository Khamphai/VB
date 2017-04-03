Public Class Form31

    Private Sub Form31_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lst1.Items.Add("ນະຄອນຫຼວງວຽງຈັນ")
        Lst1.Items.Add("ແຂວງ ວຽງຈັນ")
        Lst1.Items.Add("ແຂວງ ບໍລິຄຳໄຊ")
        Lst1.Items.Add("ແຂວງ ສະຫວັນນະເຂດ")
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Txt1.Text = "" Then
            MessageBox.Show("Please Fill Data to TextBox")
            Txt1.Focus()
        Else
            Lst1.Items.Add(Txt1.Text)
            Txt1.Clear()
            Txt1.Focus()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Lst1.Items.RemoveAt(Lst1.SelectedIndex)
        Catch ex As Exception
            MessageBox.Show("Please Select List Data")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If Txt1.Text = "" Then
                MessageBox.Show("Please Fill Data to TextBox")
                Txt1.Focus()
            Else
                Lst1.Items(Lst1.SelectedIndex) = Txt1.Text
                Txt1.Clear()
                Txt1.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Please Select List Data")
        End Try

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If Txt1.Text = "" Then
                MessageBox.Show("Please Fill Data to TextBox")
                Txt1.Focus()
            Else
                Lst1.Items.Insert(Lst1.SelectedIndex, Txt1.Text)
                Txt1.Clear()
                Txt1.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Please Select Index")
        End Try
    End Sub
End Class