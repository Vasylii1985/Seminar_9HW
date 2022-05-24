/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120*/
int SumNumbers(int numberM, int numberN, int sum = 0)
{
    if (numberM <= numberN)
    {
        sum += numberM;
        sum = SumNumbers(++numberM, numberN, sum);
    }
     return sum;
}

int numM = 1;
int numN = 15;
int sumNumbers = SumNumbers(numM, numN);
Console.WriteLine($"Сумма натуральных элементов от {numM} до {numN} равна {sumNumbers}");