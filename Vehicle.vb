Public Class Vehicle
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Price As Decimal

    Public Overrides Function ToString() As String
        Return $"{Year} {Make} {Model} - {Price:C}"
    End Function
End Class