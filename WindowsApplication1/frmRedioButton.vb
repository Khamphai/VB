Public Class frmRedioButton

    Private Sub frmRedioButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pic1.Image = My.Resources._01
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Interval = 800
        Static Dim iImageRand As Integer
        Select Case iImageRand
            Case 0
                Try
                    Pic1.Visible = True
                    Rad1.Checked = True
                    Pic1.Image = My.Resources._01
                    Rad2.Checked = False
                    Rad3.Checked = False
                    Rad4.Checked = False
                    Rad5.Checked = False
                    iImageRand += 1
                Catch ex As Exception

                End Try
            Case 1
                Try
                    Pic1.Visible = True
                    Rad1.Checked = False
                    Rad2.Checked = True
                    Pic1.Image = My.Resources._02
                    Rad3.Checked = False
                    Rad4.Checked = False
                    Rad5.Checked = False
                    iImageRand += 1
                Catch ex As Exception

                End Try
            Case 2
                Try
                    Pic1.Visible = True
                    Rad1.Checked = False
                    Rad2.Checked = False
                    Rad3.Checked = True
                    Pic1.Image = My.Resources._03
                    Rad4.Checked = False
                    Rad5.Checked = False
                    iImageRand += 1
                Catch ex As Exception

                End Try
            Case 3
                Try
                    Pic1.Visible = True
                    Rad1.Checked = False
                    Rad2.Checked = False
                    Rad3.Checked = False
                    Rad4.Checked = True
                    Pic1.Image = My.Resources._04
                    Rad5.Checked = False
                    iImageRand += 1
                Catch ex As Exception

                End Try
            Case 4
                Try
                    Pic1.Visible = True
                    Rad1.Checked = False
                    Rad2.Checked = False
                    Rad3.Checked = False
                    Rad4.Checked = False
                    Rad5.Checked = True
                    Pic1.Image = My.Resources._05
                    iImageRand = 0
                Catch ex As Exception

                End Try
        End Select
    End Sub

End Class


'Dim max As Integer = 5
'Dim rnd As New Random
'Dim rand As Integer = rnd.Next(1, max + 1)
'Dim i As Integer = 1
'Dim number(max - 1) As Integer
'For i = 0 To max - 1
'    If number(i) = rand Then
'        rand = rnd.Next(1, max + 1)
'        i = -1
'    ElseIf number(i) = 0 Then
'        number(i) = rand
'        rand = rnd.Next(1, max + 1)
'        If i = max - 1 Then
'            Exit For
'        End If
'        i = -1
'    End If
'Next
'Timer1.Interval = number(i)
'i += 1
'ChangeImage()

'Private Sub ChangeImage()
'    Static Dim iImage1 As Integer
'    Select Case iImage1
'        Case 0
'            Try
'                Pic1.Visible = True
'                Rad1.Checked = True
'                Pic1.Image = My.Resources._01
'                Rad2.Checked = False
'                Rad3.Checked = False
'                Rad4.Checked = False
'                Rad5.Checked = False
'                iImage1 += 1
'            Catch ex As Exception

'            End Try
'        Case 1
'            Try
'                Pic1.Visible = True
'                Rad1.Checked = False
'                Rad2.Checked = True
'                Pic1.Image = My.Resources._02
'                Rad3.Checked = False
'                Rad4.Checked = False
'                Rad5.Checked = False
'                iImage1 += 1
'            Catch ex As Exception

'            End Try
'        Case 2
'            Try
'                Pic1.Visible = True
'                Rad1.Checked = False
'                Rad2.Checked = False
'                Rad3.Checked = True
'                Pic1.Image = My.Resources._03
'                Rad4.Checked = False
'                Rad5.Checked = False
'                iImage1 += 1
'            Catch ex As Exception

'            End Try
'        Case 3
'            Try
'                Pic1.Visible = True
'                Rad1.Checked = False
'                Rad2.Checked = False
'                Rad3.Checked = False
'                Rad4.Checked = True
'                Pic1.Image = My.Resources._04
'                Rad5.Checked = False
'                iImage1 += 1
'            Catch ex As Exception

'            End Try
'        Case 4
'            Try
'                Pic1.Visible = True
'                Rad1.Checked = False
'                Rad2.Checked = False
'                Rad3.Checked = False
'                Rad4.Checked = False
'                Rad5.Checked = True
'                Pic1.Image = My.Resources._05
'                iImage1 = 0
'            Catch ex As Exception

'            End Try
'    End Select
'End Sub

