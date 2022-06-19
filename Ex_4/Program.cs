/*Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N*/
 Console.Clear();
 Console.WriteLine("Введите число");
 int num_N = int.Parse(Console.ReadLine());
 int oper_num = 0;
 while (num_N > oper_num - 1)
 {
    int res = oper_num % 2;
    if (res == 0)
    {
        Console.Write(oper_num);
        Console.Write(",");
    }
    oper_num++;
 }
 Console.WriteLine(" - все четные числа");
 Console.WriteLine("Программа завершена!");


