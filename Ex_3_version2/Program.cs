//Четность числа (с поправкой на семинаре)
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int res = num % 2;
Console.WriteLine(res);
if (res == 0)
{
    Console.Write(num);
    Console.WriteLine(" - Число четное");
}
else
{
    Console.Write(num);
    Console.WriteLine(" - Число нечетное");
}
Console.WriteLine("Программа завершена!");
