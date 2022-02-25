Public Class Employee


    Private name As String
    Private rate As Double
    Private hours As Double

    Public Sub SetHours(ByVal _hours As Double)

        hours = _hours

    End Sub

    Public Sub SetRate(ByVal _rate As Double)

        rate = _rate

    End Sub

    Public Sub SetName(ByVal _name As String)

        name = _name

    End Sub

    Public Function GetRate() As Double

        Return rate

    End Function

    Public Function GetHours() As Double

        Return hours

    End Function

    Public Function GetName() As String

        Return name

    End Function

    Public Function GetPay() As Double

        Return GetRate() * GetHours()

    End Function

End Class
