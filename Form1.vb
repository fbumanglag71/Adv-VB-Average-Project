
Public Class Form1
    Dim stats As New Statistics()  ''creates new statistics object instance

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        ''add parse number to statistics array
        stats.AddNumber(Double.Parse(txtNumber.Text))
        txtNumber.Clear()  ''clears input text box
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        ''calculates average using Statistics class method
        Dim average As Double = stats.Average()
        ''set average value to text
        txtAverage.Text = average.ToString()
    End Sub
End Class

Public Class Statistics
    Private numbers(49) As Double  ''array hold up to 50 double values
    Private count As Integer       ''variable tracks count of numbers

    Public Sub AddNumber(ByVal number As Double)
        ''adds number to array, increments count
        numbers(count) = number
        count += 1
    End Sub

    Public Function Average() As Double
        ''calcualates sum, divides by count
        Dim sum As Double = 0
        For i As Integer = 0 To count - 1
            sum += numbers(i)
        Next
        Return sum / count
    End Function
End Class
