int height = 5;

for (int i = 1; i <= height; i++)
{
    int stars = 2 * (height - i) + 1;
    for (int j = 0; j < i - 1; j++)
    {
        Console.Write(" ");
    }

    for (int k = stars; k >= 1; k--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

