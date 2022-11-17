// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""2, 4""
//M = 4; N = 8. -> ""4, 6, 8""
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
NaturaEvenMToN(m, n);


void NaturaEvenMToN(int m, int n)
{
    if (m > n)
    {
        return;
    }
    else
    {
        NaturaEvenMToN(m, n -1);
        if (n % 2 == 0)
        {
            Console.Write(n + " ");
        }
    }
}


 /*
 Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30
 */
 
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

SumFromMToN(M, N);

// вызов функции "сумма чисел от M до N"
void SumFromMToN(int M, int N)
{
    Console.Write(SumMN(M - 1, N));
}

// функция сумма чисел от M до N
int SumMN(int M, int N)
{
    int res = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        res = M + SumMN(M, N);
        return res;
    }
}

