/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9*/

int AckermanFun(int numberM, int numberN, int result = 0)
{
    if (numberM == 0)
    {
        result = numberN + 1;
    }
    else if (numberM > 0 && numberN == 0)
    {
        result = AckermanFun(numberM - 1, 1, result);
    }
    else if (numberM > 0 && numberN > 0)
    {
        numberN = AckermanFun(numberM, numberN - 1, result);
        result = AckermanFun(numberM - 1, numberN, result);
    }
    return result;
}

int numM = 2;
int numN = 3;
int res = AckermanFun(numM, numN);
Console.WriteLine($"n = {numM}, m = {numN} функция Аккермана = {res}");
