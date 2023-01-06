/*
Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.
1, 3, 8, 3, 2 -> 11
8, 3, 4, 2 -> 28
*/

int RandomArrayLength = new Random().Next(11);
int[] arrayOfRandomNumbers = new int[RandomArrayLength];
Random filler = new Random();
int count = 0;
for(int i = RandomArrayLength-1; i > -1; i--)
{
    arrayOfRandomNumbers[i] = filler.Next(10);
}
for(int i = 0, j = RandomArrayLength -1; i < RandomArrayLength / 2; i++, j--)
{
    count += arrayOfRandomNumbers[i] * arrayOfRandomNumbers[j];
}
Console.Write($"Array: [ ");
for(int i = 0; i < RandomArrayLength; i++)
{
   Console.Write($" {arrayOfRandomNumbers[i]} ");
}
Console.Write($" ]");
Console.WriteLine();
Console.WriteLine($"Sum of products of pairs is: {count}");