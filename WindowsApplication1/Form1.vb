Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(Convert.ToInt32(lblNum1.Text) + Convert.ToInt32(lblNum2.Text))
        lblresualt.Text = txtNum1.Text + +txtNum2.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MessageBox.Show(lblNum1.Text - lblNum2.Text)
        lblresualt.Text = txtNum1.Text - txtNum2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'MsgBox(lblNum1.Text * lblNum2.Text)
        lblresualt.Text = txtNum1.Text * txtNum2.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'MessageBox.Show(lblNum1.Text / lblNum2.Text)
        lblresualt.Text = txtNum1.Text / txtNum2.Text
    End Sub
End Class
