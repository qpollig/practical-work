Module Module1
    Sub Main()
        ' Объявление переменных
        Dim a As Double
        Dim b As Double
        Dim x As Double
        Dim y As Double
        Dim F As Double

        ' Ввод значений переменных
        Console.Write("Введите значение a: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Введите значение b: ")
        b = Convert.ToDouble(Console.ReadLine())
        Console.Write("Введите значение x (в радианах): ")
        x = Convert.ToDouble(Console.ReadLine())
        Console.Write("Введите значение y (в радианах): ")
        y = Convert.ToDouble(Console.ReadLine())

        ' Вычисление значений
        Dim sinx As Double = Math.Sin(x)
        Dim cosy As Double = Math.Cos(y)
        Dim num As Double = sinx ^ 2
        Dim denom As Double = cosy ^ 2 - sinx ^ 2

        ' Проверка деления на ноль
        If denom = 0 Then
            Console.WriteLine("Ошибка: деление на ноль.")
            Return
        End If

        Dim expr As Double = a * x ^ 2 + a * b * x * y + b * y ^ 2
        Dim cubert As Double = Math.Pow(expr, 1 / 3)

        ' Вычисление F
        F = (num / denom) * cubert

        ' Вывод результата
        Console.WriteLine("Результат F: " & F)

        ' Ожидание нажатия клавиши для завершения программы
        Console.ReadKey()
    End Sub
End Module
