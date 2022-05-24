//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.//
Console.WriteLine("Задайте число N: ");
 int n = Convert.ToInt32(Console.ReadLine());

 int result = Rekurs(n);
 Console.WriteLine(result);

 int Rekurs(int number)
 {  
    if (number == 1)
    {
        return number; 
    }
    Console.Write(number + ", ");
    return Rekurs (number - 1);
 }