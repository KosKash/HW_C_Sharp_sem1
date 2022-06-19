//Четность числа (свой вариант)
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int res = num / 2;
int checker = res * 2;
if (checker == num)
{
    Console.Write(num);
    Console.WriteLine(" - число четное.");
}
else
{
    Console.Write(num);
    Console.WriteLine(" - число нечетное.");
}
Console.WriteLine("Программа завершена!");