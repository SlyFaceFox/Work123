using System;
public class MainClass
{
    public static void Main()
    {
        double a, b, r, h, z, s;
        Console.WriteLine("Выбор типа комнат: 1) Треугольная, 2) Прямоугольная, 3) Круглая");
        z = int.Parse(Console.ReadLine());
        if (z==1)
        {
            Console.WriteLine("Введите длинну комнаты:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширинну комнаты:");
            b = int.Parse(Console.ReadLine());
            s = a * b;
            Console.WriteLine($"Ответ: {s}");
        }
        else if (z==2)
        {
            Console.WriteLine("Введите длинну стенны:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину комнаты");
            h = int.Parse(Console.ReadLine());
            s = (h * a) / 2;
            Console.WriteLine($"Площадь комнаты равна: {s}");

        }
        else if (z==3)
        {
            Console.WriteLine("Радиус комнаты:");
            r = int.Parse(Console.ReadLine());
            s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь комнаты равна: {s}");
        }
        else
        {
            Console.WriteLine("Введённое значение неизвестно");
        }

    }
}
