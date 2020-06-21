Imports System.Data.Odbc
Imports System.Net.NetworkInformation
Imports BibliotecaDeClases
Public Class Gestion
    'Conexion con la base de datos 
    Property conODBC As New OdbcConnection("dsn=MyConexionODBC;uid=root;pwd=;")
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        'Boton de volver
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        'Selecciona la accion
        Select Case cbo_accion.SelectedIndex
            Case -1
                'Sin opcion

                btn_confirmar.Visible = False
                txt_identificacion.Enabled = False
                txt_nombre.Enabled = False
                txt_sintomas.Enabled = False

            Case 0
                'Añadir

                btn_confirmar.Visible = True
                txt_identificacion.Enabled = True
                txt_nombre.Enabled = True
                txt_sintomas.Enabled = True

                If (agregarPatologia(txt_identificacion.Text, txt_nombre.Text, txt_sintomas.Text) = True) Then
                    MsgBox("Se ha añadido el registro.")
                    cargarTabla()
                End If

            Case 1
                'Modificar

                btn_confirmar.Visible = True
                txt_identificacion.Enabled = True
                txt_nombre.Enabled = True
                txt_sintomas.Enabled = True

                If (modificarPatologia(txt_identificacion.Text, txt_nombre.Text, txt_sintomas.Text) = True) Then
                    MsgBox("Se ha modificado el registro.")
                    cargarTabla()
                End If

            Case 2
                'Eliminar

                btn_confirmar.Visible = True
                txt_identificacion.Enabled = True
                txt_nombre.Enabled = False
                txt_sintomas.Enabled = False

                If (eliminarPatologia(txt_identificacion.Text) = True) Then
                    MsgBox("Se ha eliminado el registro.")
                    cargarTabla()
                End If

        End Select
    End Sub

    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTabla()
    End Sub

    Private Function agregarPatologia(nomb As String, sint As String, idpat As Integer) As Boolean
        'Agregar patologia

        Dim guardado As Boolean = False
        Dim consulta As String = "INSERT INTO Patologia (sintoma,idpat,nombre) VALUES (" & idpat.ToString & "," & nomb & "," & sint & ")"

        Try
            Dim comando As New OdbcCommand(consulta, conODBC)

            conODBC.Open()
            comando.ExecuteNonQuery()
            conODBC.Close()

            guardado = True

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Return guardado
    End Function
    Private Function modificarPatologia(nomb As String, sint As String, idpat As Integer) As Boolean
        'Modificar patologia

        Dim modificado As Boolean = False
        Dim consulta As String = "UPDATE Patologia SET nombre ='" & nomb & "',sintoma = '" & sint & "' WHERE idpat=" & idpat

        Try
            Dim comando As New OdbcCommand(consulta, conODBC)

            conODBC.Open()
            comando.ExecuteNonQuery()
            conODBC.Close()

            modificado = True

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        Return modificado
    End Function

    Private Function eliminarPatologia(id As Integer) As Boolean
        'Eliminar patologia

        Dim eliminado As Boolean = False
        Dim consulta As String = "DELETE FROM Patologia WHERE idpat=" & id

        Try
            Dim comando As New OdbcCommand(consulta, conODBC)

            conODBC.Open()
            comando.ExecuteNonQuery()
            conODBC.Close()

            eliminado = True

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        Return eliminado
    End Function

    Private Function buscarPatologia(idpat As Integer) As Boolean
        'Buscar patologia
        Dim encontrado As Boolean = False
        Dim consulta As String = "SELECT * FROM Patologia WHERE idpat=" & idpat.ToString

        Try
            Dim comando As New OdbcCommand(consulta, conODBC)
            conODBC.Open()

            Dim reader As OdbcDataReader = comando.ExecuteReader

            If reader.FieldCount > 0 Then

                encontrado = True
                While reader.Read
                    txt_sintomas.Text = reader(0).ToString
                    txt_nombre.Text = reader(0).ToString
                End While

            End If
            reader.Close()
            conODBC.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try


        Return encontrado
    End Function

    Private Sub cargarTabla()
        'Carga la tabla de la base de datos
        Dim dt As New DataTable
        Dim consulta = "SELECT * FROM Patologia"

        Try
            Dim comando As New OdbcCommand(consulta, conODBC)

            conODBC.Open()
            Dim reader As OdbcDataReader = comando.ExecuteReader()
            dt.Load(reader)
            conODBC.Close()

            dgvPatologias.DataSource = dt

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cbo_accion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_accion.SelectedIndexChanged
        'Bloqueo de text box segun la opcion
        Select Case cbo_accion.SelectedIndex
            Case 0
                'Añadir
                lbl_mod1.Visible = False
                lbl_mod2.Visible = False
                lbl_mod3.Visible = False
                btn_confirmar.Visible = True
                txt_identificacion.Enabled = True
                txt_nombre.Enabled = True
                txt_sintomas.Enabled = True
            Case 1
                'Modificar
                lbl_mod1.Visible = True
                lbl_mod2.Visible = True
                lbl_mod3.Visible = True
                btn_confirmar.Visible = True
                txt_identificacion.Enabled = True
                txt_nombre.Enabled = True
                txt_sintomas.Enabled = True
            Case 2
                'Eliminar
                lbl_mod1.Visible = False
                lbl_mod2.Visible = False
                lbl_mod3.Visible = False
                btn_confirmar.Visible = True
                txt_identificacion.Enabled = True
                txt_nombre.Enabled = False
                txt_sintomas.Enabled = False
        End Select
    End Sub
End Class