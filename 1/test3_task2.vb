Module Module1
    Sub Main()
        ' Объявление переменной
        Dim x As Double
        Dim y As Double

        ' Ввод значения переменной x
        Console.Write("Введите значение x: ")
        x = Convert.ToDouble(Console.ReadLine())

        ' Определение значения y в зависимости от x
        If x < -1 Then
            y = Math.Sin(x + 1) ^ 2
        ElseIf x >= -1 AndAlso x < 1 Then
            y = -(1 + Math.Cos(Math.PI * x))
        Else
            y = Math.Sin(x - 1) ^ 2
        End If

        ' Вывод результата
        Console.WriteLine("Результат y: " & y)
    End Sub
End Module
