Module Module1
    Sub Main()
        Dim z, i As Byte
        Dim r = New System.Random
        Do Until (z = 30)
            i = r.Next(4) \ 2
            If i = 1 Then
                Console.WriteLine("ズン")
            Else
                Console.WriteLine("ドコ")
            End If
            z = ((z << 4) >> 3) Or i
        Loop
        Console.WriteLine("キ・ヨ・シ！")
    End Sub
End Module
