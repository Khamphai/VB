Public Class frmMainMenu

    Private Sub ຂາຍສນຄາToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂາຍສນຄາToolStripMenuItem.Click
        frmRes.MdiParent = Me
        frmRes.Show()
    End Sub

    Private Sub ຂມນຫວໜວນToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນຫວໜວນToolStripMenuItem.Click
        frmUnit.MdiParent = Me
        frmUnit.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Close()
    End Sub

    Private Sub ຂມນປະເພດສນຄາToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນປະເພດສນຄາToolStripMenuItem.Click
        frmProductType.MdiParent = Me
        frmProductType.Show()
    End Sub

    Private Sub ຂມນສນຄາToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນສນຄາToolStripMenuItem.Click
        frmProducts.MdiParent = Me
        frmProducts.Show()
    End Sub
End Class