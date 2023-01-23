// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number_remains = number % 2;
if(number_remains == 0)
{
    Console.WriteLine($"{number} - четное число");
}
else Console.WriteLine($"{number} - нечетное число");