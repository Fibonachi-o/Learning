/* //Проверка на содержание в конце строки
Console.WriteLine("Введите почту:");
string email = Console.ReadLine();
if (email.EndsWith("@gmail.com") ||
    email.EndsWith("@yandex.ru"))
{
    Console.WriteLine("Почта поддерживается.");
}
else
{
    Console.WriteLine("Неизвестный почтовой сервис.");
}
*/

Console.WriteLine("Введите предложение:");
string text = Console.ReadLine();

string[] words = text.Split(' ', ',', StringSplitOptions.RemoveEmptyEntries);
int count = 0;

for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words[i]);
    // if (words[i] != "")  //Подсчёт слов без параметра StringSplitOptions.RemoveEmptyEntries
    // {
    //     count++;
    // }
}
//Console.WriteLine("Количество слов: " + count); //Подсчёт слов без параметра StringSplitOptions.RemoveEmptyEntries
Console.WriteLine("Количество слов: " + words.Length);