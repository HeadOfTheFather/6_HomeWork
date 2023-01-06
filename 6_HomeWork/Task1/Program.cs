/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Не использовать массив.

M=5 ; 0, 7, 8, -2, -2 -> 2
M=5 ; -1, -7, 567, 89, 223 -> 3
*/
Console.WriteLine("Enter the amount of numbers");
int M = Convert.ToInt32(Console.ReadLine());
int CountOfPositiveNumbers = 0;
for (int i = 1; i <= M; i++)
{
    Console.WriteLine($"Enter the {i} number");
    if (Convert.ToInt32(Console.ReadLine()) > 0)
    {
        CountOfPositiveNumbers = CountOfPositiveNumbers + 1;
    }
}
Console.WriteLine($"There are {CountOfPositiveNumbers} positive numbers out of your {M} entered numbers!");