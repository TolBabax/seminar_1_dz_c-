// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_3 = Convert.ToInt32(Console.ReadLine());
int number_max = number_1;

if(number_2 > number_1)
{
    number_max = number_2;
    if(number_2 > number_3)
    {
        number_max = number_2;
    }
    else number_max = number_3;
}
else 
    {
        if(number_1 > number_3)
        {
            number_max = number_1;
        }
        else number_max = number_3;
        
    }
Console.Write($"Максимальное число: {number_max}");