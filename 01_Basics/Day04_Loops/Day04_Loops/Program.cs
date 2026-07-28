using System.Diagnostics.CodeAnalysis;




Console.WriteLine("Task 1:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();

Console.WriteLine("Task 2:");
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine();

Console.WriteLine("Task 3:");
int number = 2;
while (number <= 20)
{
    Console.WriteLine(number);
    number = number + 2;
}
Console.WriteLine();

Console.WriteLine("Task 4:");
Console.WriteLine("Введите число:");
int uNumber = int.Parse(Console.ReadLine());
for (int i = 1; i <= uNumber; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();

Console.WriteLine("Task 5:");
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= num; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);
Console.WriteLine();


Console.WriteLine("Task stars up:");
Console.WriteLine("Введите число:"); // Звездочки возрастание
int inputNumber = int.Parse(Console.ReadLine());
string star = "*";
for (int i = 1; i <= inputNumber; i++)
{
    Console.WriteLine(star);
    star += "*";
}
Console.WriteLine();

Console.WriteLine("Task stars dawn:"); // Звездочки убывание
Console.WriteLine("Введите число:");
int starNumber = int.Parse(Console.ReadLine());
char stars = '*';
for (int i = starNumber; i >= 1; i--)
{
    string result = new string(stars, i);
    Console.WriteLine(result);
}