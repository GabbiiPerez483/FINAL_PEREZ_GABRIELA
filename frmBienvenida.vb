Public Class frmBienvenida
    Private Sub Bienvenida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        FRMLOGEO.Show()
        Me.Close()
    End Sub
End Class
