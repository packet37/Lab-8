//using System;
//Задание 1
////Начальный вариант
//TabFunc(-2.0 * Math.PI, Math.PI * 2.0, Math.PI / 6.0, Cos);
//TabFunc(-2.0 * Math.PI, Math.PI * 2.0, Math.PI / 6.0, TaskB);
//TabFunc(-2.0 * Math.PI, Math.PI * 2.0, Math.PI / 6.0, x => (-Math.Pow((x / Math.PI), 2)) - 2 * x + 5 * Math.PI);
//TabFunc(-2.0 * Math.PI, Math.PI * 2.0, Math.PI / 6.0, Cicle);
//TabFunc(-2.0 * Math.PI, Math.PI * 2.0, Math.PI / 6.0, TaskE);
////Вариант в цикле + пункт г 
////Делегат предикат возвращает значение bool
//static int CountFunc(double a, double b, double step, Predicate<double> condition, ArifmFunc del)
//{
//    int count = 0;
//    for (double x = a; x <= b; x += step)
//    {
//        if (condition(del(x)))
//        {
//            count++;
//        }
//    }
//    return count;
//}
//ArifmFunc[] funcs = { Cos, TaskB, x => (-Math.Pow((x / Math.PI), 2)) - 2 * x + 5 * Math.PI, Cicle, TaskE };
//double a = -2.0 * Math.PI;
//double b = Math.PI * 2.0;
//double step = Math.PI / 6.0;
//int negCount = 0;
//int rangeCount = 0;
//foreach (var del in funcs)
//{
//    TabFunc(a,b,step, del);
//    negCount += CountFunc(a, b, step, x => x < 0, del);
//    rangeCount += CountFunc(a, b, step, x => x >= -1 && x <= 1, del);
//}
//Console.WriteLine($"Общее количество отрицательных значений функций: {negCount}");
//Console.WriteLine($"Общее количество значений из [-1; 1]: {rangeCount}");

//static double Cicle(double x)
//{
//    double y = 0.0;
//    for (int k = 1;k< 101;k++)
//    {
//        y += Math.Pow(((x / Math.PI * k) - 1), 2);
//    }
//    return y;
//}

//static double TaskE (double x)
//{
//    if (x<0)
//    {
//        return 1 / 4 * Math.Pow(Math.Sin(x), 2) + 1;
//    }
//    else
//    {
//        return 1 / 2 * Math.Cos(x) - 1;
//    }
//}

//static double Cos (double x)
//{
//    return Math.Cos (x);
//}

//static double TaskB (double x)
//{
//    return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1;
//}

//static void TabFunc(double a, double b, double step, ArifmFunc del)
//{
//    Console.WriteLine("\nЗначения функции {3} на отрезке [{0},  {1}] c шагом {2}", a, b, step, del);
//    for (double x = a; x <= b; x += step)
//    {
//        Console.WriteLine("x={0}\t f(x) = {1}", x, del(x));
//    }

//}

//delegate double ArifmFunc(double x); 

//Задание 2

using System.Text.RegularExpressions;

string[] strings = { "vegetables", "ONION", "level", "1234567890", "wheat", "sweet-potato" };

// количество строк без заглавных букв
int NoUpper = strings.Count(s => Regex.IsMatch(s, "[a-z]"));
Console.WriteLine($"Количество строк без заглавных букв: {NoUpper}");

// количество десятибуквенных строк
int TenChar = strings.Count(s => Regex.IsMatch(s, "^.{10}$"));
Console.WriteLine($"Количество десятибуквенных строк: {TenChar}");

// количество пятибуквенных слов
int FiveLetter= strings.Count(s => Regex.IsMatch(s, "\\b\\w{5}\\b"));
Console.WriteLine($"Количество пятибуквенных слов: {FiveLetter}");

//Слова, начинающиеся на W
List<string> wWords = strings.Where(s => Regex.IsMatch(s, @"\b[Ww]\w*\b")).ToList();
Console.WriteLine($"Слова, начинающиеся на 'W': {string.Join(", ", wWords)}");

// все составные слова, включающие дефис
List<string> defis = strings.Where(s => Regex.IsMatch(s, @"\b\w+-\w+\b")).ToList();
Console.WriteLine($"Слова с дефисом: {string.Join(", ", defis)}");
