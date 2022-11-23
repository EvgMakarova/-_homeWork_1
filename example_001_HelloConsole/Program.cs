// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите число a: ");
string a_String = Console.ReadLine();
int a_Arg = Convert.ToInt32(a_String);

Console.Write("Введите число b: ");
string b_String = Console.ReadLine();
int b_Arg = Convert.ToInt32(b_String);
if (a_Arg > b_Arg)
{
    Console.WriteLine(a_Arg);
}
else
{
    Console.WriteLine(b_Arg);
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число a: ");
string a_String = Console.ReadLine();
int a_Arg = Convert.ToInt32(a_String);

Console.Write("Введите число b: ");
string b_String = Console.ReadLine();
int b_Arg = Convert.ToInt32(b_String);

Console.Write("Введите число c: ");
string c_String = Console.ReadLine();
int c_Arg = Convert.ToInt32(c_String);

int max = a_Arg;
if (a_Arg > max) max = a_Arg;
if (b_Arg > max) max = b_Arg;
if (c_Arg > max) max = c_Arg;

Console.Write("max = ");
Console.Write(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число a: ");
string a_String = Console.ReadLine();
int a_Arg = Convert.ToInt32(a_String);
if (a_Arg % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число не четное");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число n: ");
string n_String = Console.ReadLine();
int n_Arg = Convert.ToInt32(n_String);

int i = 0;
while (i < n_Arg - 1)
{
    i += 2;
    Console.Write(i);
}
