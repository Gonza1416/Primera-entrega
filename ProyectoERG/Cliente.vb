Imports System.Data.Odbc

Public Class Cliente

    Property conODBC As New OdbcConnection("dsn=MyConexionODBC;uid=root;pwd=;")
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub btn_diagnostico_Click(sender As Object, e As EventArgs) Handles btn_diagnostico.Click
        cargarTabla()
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cargarTabla()
        'Carga la tabla de la base de datos
        Dim dt As New DataTable
        Dim consulta = "SELECT nombre FROM Patologia WHERE sintoma=" & txt_sintomas.Text

        Try
            Dim comando As New OdbcCommand(consulta, conODBC)

            conODBC.Open()
            Dim reader As OdbcDataReader = comando.ExecuteReader()
            dt.Load(reader)
            conODBC.Close()

            dgvDiagnostico.DataSource = dt

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

End Class