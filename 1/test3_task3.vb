Module Module1
    Function f(x As Double) As Double
        ' Определяем функцию f(x) = x^3 + 4*x^2 - 2*x
        Return x ^ 3 + 4 * x ^ 2 - 2 * x
    End Function

    Sub Main()
        Dim a As Double
        Dim b As Double
        Dim eps As Double
        Dim n As Integer = 1
        Dim integral_old As Double = 0
        Dim integral_new As Double = 0

        ' Ввод пределов интегрирования и точности
        Console.Write("Введите нижний предел a: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Введите верхний предел b: ")
        b = Convert.ToDouble(Console.ReadLine())
        Console.Write("Введите точность eps: ")
        eps = Convert.ToDouble(Console.ReadLine())

        ' Основной цикл для вычисления интеграла
        Do
            n += 1 ' Увеличиваем количество подынтервалов
            Dim h As Double = (b - a) / n ' Вычисляем ширину подынтервала
            integral_new = 0 ' Сбрасываем новое значение интеграла

            ' Вычисляем интеграл методом левых прямоугольников
            For i As Integer = 0 To n - 1
                Dim x As Double = a + i * h
                integral_new += f(x) * h ' Добавляем площадь прямоугольника
            Next

            ' Проверяем условие остановки
            If Math.Abs(integral_new - integral_old) < eps Then Exit Do

            integral_old = integral_new ' Обновляем старое значение интеграла
        Loop

        ' Выводим результат
        Console.WriteLine("Значение определенного интеграла: " & integral_new)
        
    End Sub
End Module
