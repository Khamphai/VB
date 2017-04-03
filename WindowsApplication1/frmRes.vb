Public Class frmRes
    Dim total1, total2, total3, total4, total5, total6, total7 As Integer
    Dim isTotal As Integer

    Private Sub chk1_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged
        If chk1.Checked = True Then
            txt1.Visible = True
            total1 = 6000
        Else
            txt1.Visible = False
            txt1.Text = "1"
            total1 = 0
        End If
    End Sub

    Private Sub chk2_CheckedChanged(sender As Object, e As EventArgs) Handles chk2.CheckedChanged
        If chk2.Checked = True Then
            txt2.Visible = True
            total2 = 7000
        Else
            txt2.Visible = False
            txt2.Text = "1"
            total2 = 0
        End If
    End Sub

    Private Sub frmRes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chk3_CheckedChanged(sender As Object, e As EventArgs) Handles chk3.CheckedChanged
        If chk3.Checked = True Then
            txt3.Visible = True
            total3 = 5000
        Else
            txt3.Visible = False
            txt3.Text = "1"
            total3 = 0
        End If
    End Sub

    Private Sub chk4_CheckedChanged(sender As Object, e As EventArgs) Handles chk4.CheckedChanged
        If chk4.Checked = True Then
            txt4.Visible = True
            total4 = 3000
        Else
            txt4.Visible = False
            txt4.Text = "1"
            total4 = 0
        End If
    End Sub

    Private Sub chk5_CheckedChanged(sender As Object, e As EventArgs) Handles chk5.CheckedChanged
        If chk5.Checked = True Then
            txt5.Visible = True
            total5 = 10000
        Else
            txt5.Visible = False
            txt5.Text = "1"
            total5 = 0
        End If
    End Sub

    Private Sub chk6_CheckedChanged(sender As Object, e As EventArgs) Handles chk6.CheckedChanged
        If chk6.Checked = True Then
            txt6.Visible = True
            total6 = 8000
        Else
            txt6.Visible = False
            txt6.Text = "1"
            total6 = 0
        End If
    End Sub

    Private Sub chk7_CheckedChanged(sender As Object, e As EventArgs) Handles chk7.CheckedChanged
        If chk7.Checked = True Then
            txt7.Visible = True
            total7 = 6000
        Else
            txt7.Visible = False
            txt7.Text = "1"
            total7 = 0
        End If
    End Sub


    Private Sub BOK_Click(sender As Object, e As EventArgs) Handles BOK.Click
        If chk1.Checked = False And chk2.Checked = False And chk3.Checked = False And chk4.Checked = False And chk5.Checked = False And chk6.Checked = False And chk7.Checked = False Then
            MsgBox("Please Checked Some of Food !")
        End If
        If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Or txt6.Text = "" Or txt7.Text = "" Then
            MsgBox("Please Fill Amount !")
        End If
        isTotal = 0
        If chk1.Checked = True Then
            Try
                Dim t1 As Integer
                t1 = Val(txt1.Text)
                isTotal += total1 * t1
            Catch ex As Exception

            End Try
        End If
        If chk2.Checked = True Then
            Try
                Dim t2 As Integer
                t2 = Val(txt2.Text)
                isTotal += total2 * t2
            Catch ex As Exception

            End Try
        End If
        If chk3.Checked = True Then
            Try
                Dim t3 As Integer
                t3 = Val(txt3.Text)
                isTotal += total3 * t3
            Catch ex As Exception

            End Try
        End If
        If chk4.Checked = True Then
            Try
                Dim t4 As Integer
                t4 = Val(txt4.Text)
                isTotal += total4 * t4
            Catch ex As Exception

            End Try
        End If
        If chk5.Checked = True Then
            Try
                Dim t5 As Integer
                t5 = Val(txt5.Text)
                isTotal += total5 * t5
            Catch ex As Exception

            End Try
        End If
        If chk6.Checked = True Then
            Try
                Dim t6 As Integer
                t6 = Val(txt1.Text)
                isTotal += total6 * t6
            Catch ex As Exception

            End Try
        End If
        If chk7.Checked = True Then
            Try
                Dim t7 As Integer
                t7 = Val(txt7.Text)
                isTotal += total7 * t7
            Catch ex As Exception

            End Try
        End If

        Ttotal.Text = isTotal.ToString("#,###") & " LAK"
    End Sub
End Class