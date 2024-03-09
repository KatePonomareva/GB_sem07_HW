// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 

void NaturalNumbers (int m, int n)
{
    if (m > n)
    {
        return;
    }
    Console.Write ($"{m} ");
    NaturalNumbers (m+1, n);
}

int EnterNumber (string message)
{
    Console.Write (message);
    int number = int.Parse (Console.ReadLine());
    return number;
}

int m = EnterNumber ("Введите число min:");
int n = EnterNumber ("Введите число max:");
NaturalNumbers (m, n);




// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akker(m - 1, 1);
    }
    else
    {
        return Akker(m - 1, Akker(m, n - 1));
    }
}

int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNumber("Введите число M:");
int n = EnterNumber("Введите число N:");
int result = Akker(n, m);
Console.WriteLine(result);




// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] Array = { 1, 2, 5, 0, 10, 34 };
int x = Array.Length;

void PrintNumbers(int[] Array, int i = 0)
{
    if (i < Array.Length)
    {
        PrintNumbers(Array, i + 1);
        Console.Write($"{Array[i]} ");
    }
}
PrintNumbers(Array);
