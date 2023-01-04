Imports System

Module Program
    Sub Main()

        System.Console.WriteLine("Enter any sequence of numbers followed by a space.")

        'read the array to a string

        Dim OurArrayString As String = System.Console.ReadLine()
        Dim OurArray As String()

        'split the string to an array

        OurArray = OurArrayString.Split(" ")

        'Start Bubble sort algorithm

        Dim i As Integer
        Dim j As Integer

        For i = 0 To UBound(OurArray) Step 1

            'Ubound of an array will be the maximum index of that array 
            'start another for loop

            For j = 0 To UBound(OurArray) - 1
                If CInt(OurArray(j + 1)) < CInt(OurArray(j)) Then

                    'Swapping the variables in the array

                    Dim temp As Integer = CInt(OurArray(j + 1))
                    OurArray(j + 1) = OurArray(j)
                    OurArray(j) = temp

                End If
            Next
        Next

        'display the out in the console window Console.WriteLine("the sorted array will be") 

        For Each x In OurArray
            Console.Write(x & " ")
        Next

        Console.ReadLine()

    End Sub

End Module
