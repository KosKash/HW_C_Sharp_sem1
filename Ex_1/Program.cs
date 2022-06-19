/* Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее.*/
Console.Clear();
Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());
if (numA > numB)
{
    Console.Write("Max = "); 
    Console.WriteLine(numA);
    Console.Write("Min = "); 
    Console.WriteLine(numB);
} 
else
{
    Console.Write("Max = "); 
    Console.WriteLine(numB);
    Console.Write("Min = "); 
    Console.WriteLine(numA);
}
Console.WriteLine("Программа завершена");