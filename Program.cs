Console.WriteLine("==============================");
Console.WriteLine("Анкета пользователя");
Console.WriteLine("==============================");
Console.WriteLine();
Console.WriteLine("Введите имя:");
string name = Console.ReadLine();
Console.WriteLine("Введите возраст:");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Введите рост (м):");
double height = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вес (кг):");
double weight = double.Parse(Console.ReadLine());
Console.WriteLine($"Привет, {name}!");
Console.WriteLine();
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine();
Console.WriteLine($"Рост: {height} м");
Console.WriteLine();
Console.WriteLine($"Вес: {weight} кг");
Console.WriteLine();
Console.WriteLine($"Через год вам будет {age + 1} лет");
Console.WriteLine();
double imt = weight / (height * height);

if (imt < 18.5)
{
    Console.WriteLine($"Ваш ИМТ: {imt:F2}");
    Console.WriteLine("Недостаток массы");
}

else if (18.5 <= imt && imt <= 24.9)
{
    Console.WriteLine($"Ваш ИМТ: {imt:F2}");
    Console.WriteLine("Норма");
}

else if (25 <= imt && imt <= 29.9)
{
    Console.WriteLine($"Ваш ИМТ: {imt:F2}");
    Console.WriteLine("Избыточный вес");
}

else if (imt >= 30)
{
    Console.WriteLine($"Ваш ИМТ: {imt:F2}");
    Console.WriteLine("Ожирение");
}