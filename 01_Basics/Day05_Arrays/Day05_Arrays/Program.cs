//Задача 1 - Вывод всех значений массива
/* int[] numbers = { 5, 10, 15, 20, 25 };
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
*/

//Задача 2 - Вывод суммы значений массива
/* int[] numbers = { 12, 7, 25, 4, 18 };
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);
*/

//Задача 3 - Нахождение максимального значения в массиве
/* int[] numbers = { 12, 7, 25, 4, 18 };
int max = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine(max);
*/

//Задача 4 - Нахождение минимального значения в массиве
/*int[] numbers = { 12, 7, 25, 4, 18 };
int min = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine(min);
*/

//Задача 5 - Нахождение минимального, максимального значения и суммы значений в массиве
/* int[] numbers = { 12, 7, 25, 4, 18 };
int min = numbers[0];
int max = numbers[0];
int sum = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }

    if (numbers[i] > max)
    {
        max = numbers[i];
    }

    sum += numbers[i];
}
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine(sum);
*/

//Задача 6 - нахождение определенного значения
int[] numbers = { 12, 7, 25, 4, 18 };
string message = "Число не найдено";
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 25)
    {
        message = "Число найдено";
        i = numbers.Length;
    }
}
Console.WriteLine(message);