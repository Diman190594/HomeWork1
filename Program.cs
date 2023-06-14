//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int maxNumber = 0;
int minNumber = 0;

if (numberA > numberB)
{
    maxNumber = numberA;
    minNumber = numberB;
}
else
{
    maxNumber = numberB;
    minNumber = numberA;
}

Console.WriteLine("Максимальное число " + maxNumber + " и минимальное число " + minNumber);
*/

//Задача 4: Напишите программу, которая принимает 
//на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Enter first number: ");
int firtsNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondsNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = 0;

if (firtsNumber > maxNumber)
{
    maxNumber = firtsNumber;
}
if (secondsNumber > maxNumber)
{
    maxNumber = secondsNumber;
}
if (thirdNumber > maxNumber)
{
    maxNumber = thirdNumber;
}

Console.WriteLine("Максимальное число = " + maxNumber);
*/

//Задача 6: Напишите программу, которая на вход принимает
//число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int checkNumber = number % 2;

if (checkNumber == 0)
{
    Console.WriteLine(checkNumber + " четное");
}
else
Console.WriteLine(checkNumber + " нечетное");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}