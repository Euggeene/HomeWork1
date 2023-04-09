// HOMEWORK

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b=Convert.ToInt32(Console.ReadLine());

// if(b > a)
// {
//     Console.Write("Большее число: ");
//     Console.WriteLine(b);
// }
// else
// {
//     Console.Write("Большее число: ");
//     Console.WriteLine(a);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.

// Console.WriteLine("Введите первое число");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int c=Convert.ToInt32(Console.ReadLine());
// int max = a;

// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
//  Console.Write("Большее число: ");
//  Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = n%2;

// if(result == 0)
// {
//     Console.Write(n);
//     Console.WriteLine(" -чётное число");
// }
// else
// {
//     Console.Write(n);
//     Console.WriteLine(" -нечётное число");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (N > 1)
{
    Console.Write("Чётные числа в диапазоне от 1 до ");
    Console.Write(N);
    Console.WriteLine(": ");

    while (count <= N)
    {    
     Console.WriteLine(count);
     count+=2;
    }
}
else
{
     Console.WriteLine("Неверный диапазон");
}