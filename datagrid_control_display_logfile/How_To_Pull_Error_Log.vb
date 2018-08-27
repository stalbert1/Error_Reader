Public Class frmPdf

    Private Sub frmPdf_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.AxAcroPDF1.LoadFile("remote training manual.pdf")

    End Sub

    Private Sub Label2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.AxAcroPDF1.setCurrentPage(12)

    End Sub

    Private Sub Label3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.AxAcroPDF1.setCurrentPage(15)
    End Sub

    Private Sub Label4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.AxAcroPDF1.setCurrentPage(18)
    End Sub

    Private Sub Label5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.AxAcroPDF1.setCurrentPage(21)
    End Sub

    Private Sub Label6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.AxAcroPDF1.setCurrentPage(22)
    End Sub
End Class