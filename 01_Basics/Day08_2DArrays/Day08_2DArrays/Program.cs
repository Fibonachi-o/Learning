/*
int[,] numbers =  //Создание массива и вывод определенного индекса
{
    {1, 2, 3 },
    {4, 5, 6 }
};

for (int i = 0; i < numbers.GetLength(1); i++)
{
    Console.Write($"{numbers[numbers.GetLength(0) - 1, i]} ");
}
*/

/*
int[,] numbers =  //Создание и вывод всего массива
{
    {1, 2, 3 },
    {4, 5, 6 }
};

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(numbers[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
*/

/*
int[,] numbers =  //Создание массива и вывод суммы значений
{
    {1, 2, 3 },
    {4, 5, 6 }
};
int sum = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum += numbers[i, j];
    }
}
Console.WriteLine(sum);
*/

/*
int[,] numbers =  //Создание массива и вывод максимального значения
{
    {1, 2, 3 },
    {4, 5, 6 }
};
int max = numbers[0, 0];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (max < numbers[i, j])
        {
            max = numbers[i, j];
        }
    }
}
Console.WriteLine(max);
*/

/*
int[,] numbers =  //Создание массива и вывод суммы каждой строки
{
    {1, 2, 3 },
    {4, 5, 6 }
};

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum += numbers[i, j];
    }
    Console.WriteLine(sum);
}
*/

/*
int[,] numbers =  //Создание массива и максимума каждой строки
{
    {1, 2, 3 },
    {4, 5, 6 }
};

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int max = numbers[i, 0];
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (max < numbers[i, j])
        {
            max = numbers[i, j];
        }
    }
    Console.WriteLine(max);
}
*/

int[,] numbers =  //Создание массива и вывод суммы каждого столбца
{
    {1, 2, 3 },
    {4, 5, 6 }
};

for (int i = 0; i < numbers.GetLength(1); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        sum += numbers[j, i];
    }
    Console.WriteLine(sum);
}
