Module Module1
    Dim Alpha() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}
    Sub Main()
        Dim c2s As Char = Console.ReadLine
        Console.WriteLine(c2s & " found at location " & BinarySearch(c2s))
        Console.ReadKey()
    End Sub

    Function BinarySearch(ByVal value As Char) As Integer
        Dim middle, LBound, UBound As Integer
        Dim isFound As Boolean = False
        LBound = 0
        UBound = 9
        While UBound >= LBound And isFound = False
            middle = (LBound + UBound) \ 2
            If Alpha(middle) = value Then
                isFound = True
                Return middle
            ElseIf value < Alpha(middle) Then
                UBound = middle - 1
            Else
                LBound = middle + 1
            End If
        End While
        Return -1
    End Function
End Module
