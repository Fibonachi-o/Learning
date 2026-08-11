/* //Вывод символов по индексу строки
Console.WriteLine("Введите слово:");
string word = Console.ReadLine();
char firstLetter = word[0];
char lastLetter = word[word.Length - 1];
Console.WriteLine("Длина строки: " + word.Length);
Console.WriteLine("Первый символ: " + firstLetter);
Console.WriteLine("Последний символ: " + lastLetter);
*/

/* //Создание копии строки наоборот
Console.WriteLine("Введите слово:");
string word = Console.ReadLine();
string reversed = "";
for (int i = word.Length - 1; i >= 0; i--)
{
    reversed += word[i];
}
Console.WriteLine(reversed);
*/

/* //Подсчёт кол-ва определенных символов в строке
Console.WriteLine("Введите слово:");
string word = Console.ReadLine();
int count = 0;
for (int i = 0; i < word.Length; i++)
{
    if (word[i] == 'р')
    {
        count += 1;
    }
}
Console.WriteLine("Количество букв \"р\": " + count);
*/

/* //Поиск гласных букв в строке
string word = "Hello World";
int count = 0;
for (int i = 0; i < word.Length; i++)
{
    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
    {
        count += 1;
    }
}
Console.WriteLine("Количество гласных: " + count);
*/

/* //Подсчёт кол-ва пробелов в строке 
Console.WriteLine("Введите слово:");
string word = Console.ReadLine();
int count = 0;
for (int i = 0; i < word.Length; i++)
{
    if (word[i] == ' ')
    {
        count += 1;
    }
}
Console.WriteLine("Количество пробелов: " + count);
*/

