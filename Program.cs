// Задание 1
// Console.WriteLine("Введите слово: ");
// string word = Console.ReadLine();
// Console.WriteLine($"Длина: {word.Length}");
// Console.WriteLine($"Первый символ: {word[0]}");
// Console.WriteLine($"Последний символ: {word[word.Length - 1]}");


// Console.WriteLine("подсчёт букв 'а': ");
// string word = Console.ReadLine().ToLower();
// int countA = 0;
// foreach (char i in word)
// {
//     if (i == 'а')
//     {
//         countA++;
//     }
// }
// Console.WriteLine($"кол-во букв 'а': {countA}");


// Задание 2
// Console.WriteLine("имя файла: ");
// string file = Console.ReadLine();

// if (file.EndsWith(".cs"))
// {
//     Console.WriteLine("это файл C#");
// }
// else if (file.EndsWith(".png") || file.EndsWith(".jpg"))
// {
//     Console.WriteLine(" изображение");
// }
// else
// {
//     Console.WriteLine("неизвестный тип");
// }

// if (file.StartsWith("Lab"))
// {
//     Console.WriteLine("это лабораторная работа");
// }

// if (file.Contains("test"))
// {
//     Console.WriteLine("это тестовый файл");
// }


// Задание 3
// Console.WriteLine("введите фразу: ");
// string phrase = Console.ReadLine();

// Console.WriteLine($"большими буквами: {phrase.ToUpper()}");
// Console.WriteLine($"пробелы заменены: {phrase.Replace(" ", "_")}");

// if (phrase.ToLower().Contains("стоп"))
// {
//     Console.WriteLine("Стоп-слово найдено!");
// }


// Задание 4
// string date = Console.ReadLine();
// string year = date.Substring(0, 4);
// string month = date.Substring(5, 2);
// string day = date.Substring(8, 2);
// Console.WriteLine($"{day}.{month}.{year}");

// string phone = Console.ReadLine();
// string p = phone.Substring(1, 3);
// string a = phone.Substring(4, 3);
// string b = phone.Substring(7, 2);
// string c = phone.Substring(9, 2);
// Console.WriteLine($"+7 ({p}) {a}-{b}-{c}");


// Задание 5
// Console.WriteLine("введите строку: ");
// string stroka = Console.ReadLine().ToLower();

// int p = 0;
// int g = 0;
// string glas = "аеёиоуыэюя";

// foreach (char i in stroka)
// {
//     if (i == ' ')
//     {
//         p++;
//     }
//     if (glas.Contains(i.ToString().ToLower()))
//     {
//         g++;
//     }
// }

// Console.WriteLine($"количество символов: {stroka.Length}");
// Console.WriteLine($"количество пробелов: {p}");
// Console.WriteLine($"количество гласных букв: {g}");


// Задание 6
// Console.WriteLine("введите слово: ");
// string word = Console.ReadLine();

// string w2 = "";
// for (int i = word.Length - 1; i >= 0; i--)
// {
//     w2 += word[i];
// }
// Console.WriteLine($"задом наперёд : {w2}");

// if (word.ToLower() == w2.ToLower())
// {
//     Console.WriteLine("это палиндром");
// }
// else
// {
//     Console.WriteLine("это не палиндром");
// }


// Итоговая задача. Проверка email
// Console.WriteLine("введите адрес электронной почты: ");
// string email = Console.ReadLine();

// if (email.Length < 5)
// {
//     Console.WriteLine("адрес некорректен: слишком короткий");
// }
// else
// {
//     int a = 0;
//     foreach (char i in email)
//     {
//         if (i == '@')
//         {
//             a++;
//         }
//     }

//     if (a != 1)
//     {
//         Console.WriteLine("адрес некорректен: символ @ должен быть один");
//     }
//     else if (email.StartsWith("@") || email.EndsWith("@"))
//     {
//         Console.WriteLine("адрес некорректен: @ не может быть в начале или конце");
//     }
//     else if (email.Contains(" "))
//     {
//         Console.WriteLine("адрес некорректен: содержит пробелы");
//     }
//     else if (!(email.ToLower().EndsWith(".ru") || email.ToLower().EndsWith(".com")))
//     {
//         Console.WriteLine("адрес некорректен: должен заканчиваться на .ru или .com");
//     }
//     else
//     {
//         Console.WriteLine("адрес корректен");
//         Console.WriteLine(email.ToLower());
//     }
// }


// Дополнительное задание ★★★
using System.Text;

Console.WriteLine("введите строку: ");
string str = Console.ReadLine();
string glas = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
var sb = new StringBuilder();
for (int i = 0; i < str.Length; i++)
{
    if (!glas.Contains(str[i]))
    {
        sb.Append(str[i]);
    }
}
Console.WriteLine(sb.ToString());
