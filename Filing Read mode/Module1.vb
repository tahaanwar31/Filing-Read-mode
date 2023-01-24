Module Module1

    Sub Main()
        Dim name As String
        name = ""
        FileOpen(1, My.Application.Info.DirectoryPath & "\BCCPASStudents.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, name)
            Console.WriteLine(name)
        End While
        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
