Console.WriteLine("Введите набор символов:");
string text = Console.ReadLine();
int count = 0;
int sum = 0;
for (int i = 0; i < text.Length; i++)
{
    if (text[i] >= '0' && text[i] <= '9')
    {
        count += 1;
        sum += text[i] - '0';
    }
}
Console.WriteLine("Количество цифр: " + count);
Console.WriteLine("Сумма цифр: " + sum);