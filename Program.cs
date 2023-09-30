// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string PrintNumbers(int n) 
// { 
//     if (n > 0) return $"{n} " + PrintNumbers(n - 1);
//     else return String.Empty; 
// }

// System.Console.WriteLine("Введите натуральное число "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine(PrintNumbers(n));


Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int SummaRec(int m, int n) 
{ 
    if (n <= m) 
        return m;     
    return n + SummaRec(m, n - 1); 
} 
 
System.Console.WriteLine("Введите нижнюю границу M"); 
int min = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите верхнюю границу N"); 
int max = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine(SummaRec(min, max));
