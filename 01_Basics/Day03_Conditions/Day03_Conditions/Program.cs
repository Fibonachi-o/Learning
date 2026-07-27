Console.WriteLine("Введите возраст:");
int age = int.Parse(Console.ReadLine());
if (age < 18)
{
    Console.WriteLine("Доступ запрещен");
    Console.WriteLine("Вы несовершеннолетний");
}

else if (age <= 59)
{
    Console.WriteLine("Добро пожаловать!!");
    Console.WriteLine("Вы совершеннолетний");
}

else
{
    Console.WriteLine("Вы пенсионер");
}