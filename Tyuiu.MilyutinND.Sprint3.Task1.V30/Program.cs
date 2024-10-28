using Tyuiu.MilyutinND.Sprint3.Task1.V30.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла while                                              *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
Console.WriteLine("* по формуле, при t=0,5                                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double value = 5;
int startValue = 1;
int stopValue = 10;

Console.WriteLine("Переменная X = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Произведение ряда = " + ds.GetSumSeries(value, startValue, stopValue));

Console.ReadKey();
