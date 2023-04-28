Console.WriteLine("Введите номер задачи (1,2,3)");
int Task = Convert.ToInt32(Console.ReadLine());
switch (Task)
{
case 1:
/* Напишите программу, которая принимает на вход 
пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.WriteLine("Введите пятизначное число");
string? A = Console.ReadLine();

void CheckA(string A)
{
    if(A[0]== A[4] && A[1] == A[3])
    {
        Console.WriteLine($"Число {A} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {A} не является палиндромом");
    }
}

if(A.Length == 5)
{
    CheckA(A);
}
else 
{
    Console.WriteLine("Число не пятизначно");
}
break;

case 2:
/* Задача 21

Напишите программу, которая принимает 
на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты точки А");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double B = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));
Console.WriteLine(Math.Round(B, 2));
break;
/* Задача 23

Напишите программу, которая принимает на 
вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
case 3:
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    double N = Math.Pow(i, 3);
    Console.Write($"{N}, ");
}
break;
default:
Console.WriteLine("Такой задачи нет");
break;
}