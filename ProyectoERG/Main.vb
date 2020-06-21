Imports BibliotecaDeClases
Module Main
    Private dtSintomas As New DataTable
    Private fila As DataRow
    Public Sub inicializarTabla()
        dtSintomas.Columns.Add("Identificacion")
        dtSintomas.Columns.Add("Nombre")
        dtSintomas.Columns.Add("Patologias")
    End Sub

    Public Sub agregarSintoma(pat As Patologia)
        Try
            fila = dtSintomas.NewRow()
            fila("Identificacion") = pat.identificacion
            fila("Nombre") = pat.nombre
            fila("Patologias") = pat.sintomaAsociado
            dtSintomas.Rows.Add(fila)
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Public Function getSintomas() As DataTable
        Return dtSintomas
    End Function

End Module
