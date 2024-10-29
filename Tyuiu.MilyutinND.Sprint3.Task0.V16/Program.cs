//using Tyuiu.MilyutinND.Sprint3.Task0.V16.Lib;

//DataService ds = new DataService();

//Console.Title = "Спринт #3 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
//Console.WriteLine("***************************************************************************");
//Console.WriteLine("* Спринт #3                                                               *");
//Console.WriteLine("* Тема: Оператор цикла for                                                *");
//Console.WriteLine("* Задание #0                                                              *");
//Console.WriteLine("* Вариант #16                                                             *");
//Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
//Console.WriteLine("***************************************************************************");
//Console.WriteLine("* УСЛОВИЕ:                                                                *");
//Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
//Console.WriteLine("* ряда по формуле, при x = 5                                              *");
//Console.WriteLine("***************************************************************************");
//Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
//Console.WriteLine("***************************************************************************");

//int value = 5;
//int startValue = 50;
//int stopValue = 60;

//Console.WriteLine("Переменная Х = " + value);
//Console.WriteLine("Старт шага = " + startValue);
//Console.WriteLine("Конец шага = " + stopValue);

//Console.WriteLine("***************************************************************************");
//Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
//Console.WriteLine("***************************************************************************");

//Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
//Console.ReadKey();
using System;

double s0 = 0;
double s1 = 0;
int x = 2;
for (int j = 1; j <= 3; j++)
{
    for (int k = 1; k <= 3; k++)
    {
        s0 = k*x-3;
        s1 += s0;
    }
}
Console.WriteLine(Math.Round(s1, 3));