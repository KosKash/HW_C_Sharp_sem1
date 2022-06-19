// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numC = int.Parse(Console.ReadLine());

int Max_num = numA;

if (numB > Max_num)
{
    Max_num = numB;
}
if (numC > Max_num)
{
    Max_num = numC;
}

Console.Write("Max = ");
Console.WriteLine(Max_num);
Console.WriteLine("Программа завершена");