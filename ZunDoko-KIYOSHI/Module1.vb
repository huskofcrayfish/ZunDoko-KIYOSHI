﻿Module Module1
    Sub Main()
        Dim z, i As Byte
        Dim r = New Random
        Do Until (z = 30)
            i = r.Next(4) \ 2
            Console.WriteLine(If(i, "ズン", "ドコ"))
            z = ((z << 4) >> 3) Or i
        Loop
        Console.WriteLine("キ・ヨ・シ！")
    End Sub
End Module
