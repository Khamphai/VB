Public Class frmTestIFvb
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click

        If Txt1.Text <> "" Then
            If Txt1.Text >= 0 And Txt1.Text <= 11 Then
                Lbl2.Text = "ທ່ານຍັງເປັນເດັກນ້ອຍ"
            Else
                Lbl2.Text = "ອາຍຸບໍ່ໄດ້ຢູ່ໃນເງຶ່ອນໄຂກວດສອບ"
            End If
        Else
            MsgBox("ກະລຸນາປ້ອນອາຍຸຂອງທ່ານ")
            Lbl2.Text = "ຜົນການກວດສອບ"
        End If

    End Sub
End Class