// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число для проверки");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int counter = 0;

for (int i = 0; temp != 0; i++)
{
    temp = temp / 10;
    counter++;
}
if (counter != 5) Console.Write("число не пятизначное");

else
{   int c = num / 10000;
    int d = num % 10;
    int e = num / 1000 % 10;
    int f = num % 100 / 10;

    if (c == d && e == f) Console.Write($"число {num} - палиндром");
    else Console.Write($"число {num} не является палиндромом");
}
