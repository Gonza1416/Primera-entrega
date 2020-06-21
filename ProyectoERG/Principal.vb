Public Class Principal
    Private Sub btn_cerrarsesion_Click(sender As Object, e As EventArgs) Handles btn_cerrarsesion.Click
        Me.Hide()
        Logueo.Show()
    End Sub

    Private Sub btn_gestion_Click(sender As Object, e As EventArgs) Handles btn_gestion.Click
        Me.Hide()
        Gestion.Show()
    End Sub

    Private Sub btn_cliente_Click(sender As Object, e As EventArgs) Handles btn_cliente.Click
        Me.Hide()
        Cliente.Show()
    End Sub
End Class