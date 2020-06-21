Public Class Patologia
    Public Property nombre As String
    Public Property sintomaAsociado As String
    Public Property identificacion As String

    Public Sub New(_nombre As String, _sintomaAsociado As String)
        nombre = _nombre
        sintomaAsociado = _sintomaAsociado
    End Sub
End Class
