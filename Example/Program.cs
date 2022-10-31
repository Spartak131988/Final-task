void Print(string[] array)
{
    Console.WriteLine(String.Join(' ', array));
}

string[] str = { "Hello", "2", "world", ":-)" };
string[] result = new string[str.Length];
int count = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3)
    {
        result[count] = str[i];
        count++;
    }
}
Console.Write("Массив: ");
Print(str);
Console.Write("Новый массив: ");
Print(result);