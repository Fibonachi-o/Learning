Sum(5, 2);
Multiply(5, 2);
Max(5, 2);
IsEven(8);

static int Sum(int a, int b)
{
    return a + b;
}

static int Multiply(int a, int b)
{
    return a * b;
}

static int Max(int a, int b)
{
    if (a > b)
        return a;
    else
        return b;
}

static bool IsEven(int number)
{
    return number % 2 == 0;
}










/*
int result = Square(5);
Console.WriteLine(result);

static int Square(int number)
{
    return number * number;
}
*/

/*
static int Sum(int a, int b)
{
    return a + b;
}

Console.WriteLine(Sum(3, 4));
*/

/*
Greet("Олег");
Greet("Анна");
Greet("Мия");
static void Greet(string name)
{
    Console.WriteLine($"Привет, {name}!");
    Console.WriteLine("Привет, " + name);
}
*/



/*
PrintMessage("Доброе утро!");
PrintMessage("Сегодня изучаем параметры.");
PrintMessage("Hello!");

static void PrintMessage(string message)
{
    Console.WriteLine(message);
}
*/


/*
PrintTitle();

static void PrintLine()
{
    Console.WriteLine("--------------------");
}

static void PrintTitle()
{
    PrintLine();
    Console.WriteLine("Изучаем методы");
    PrintLine();
}
*/


