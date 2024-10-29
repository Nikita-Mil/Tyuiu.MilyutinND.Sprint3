using Tyuiu.MilyutinND.Sprint3.Task3.V11.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла while                                              *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach заменить буквы q на цифру 7 в строке             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Строка: sqwreq vqwqq q");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string value = "sqwreq vqwqq q";
string res = ds.ReplaceCharOnNum(value, 'q', '7');
Console.WriteLine(res);

Console.ReadKey();