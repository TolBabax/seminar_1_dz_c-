// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number_N = 1;
int number_remains = number_N % 2;
while(number_N <= number)
{
    if(number_remains == 0)
    {
        Console.WriteLine(number_N);
    }
    number_N = number_N + 1;
    number_remains = number_N % 2;
}
if(number < 1 )
Console.WriteLine("Введите значение больше 1.");