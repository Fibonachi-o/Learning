/* 
int[,] numbers =  
{
    {1, 2, 3 },
    {4, 5, 6 },
    {7, 8, 9 }
};

for (int i = numbers.GetLength(0) - 1; i >= 0; i--)
{
    for (int j = numbers.GetLength(1) - 1; j >= 0; j--)
    {
        Console.Write($"{numbers[i, j]} ");
    }
    Console.WriteLine();
}
*/

int[,] numbers =
{
    {1, 2, 3 },
    {4, 5, 6 },
    {7, 8, 9 }
};

for (int i = 0; i < numbers.GetLength(1); i++)
{ 
    int temp = numbers[0, i];
    numbers[0, i] = numbers[numbers.GetLength(0) - 1, i];
    numbers[numbers.GetLength(0) - 1, i] = temp;
    
}