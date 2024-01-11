//C# Sharp Basic Exercises - 103

using System.Text;

static bool check(char a, char b)
{
    if (Char.ToLower(a) < Char.ToLower(b))
    { return true; }
    else { return false; }
}

string alphabet = Console.ReadLine();
string numbers = "";
StringBuilder characters = new StringBuilder();
for (int i = 0; i < alphabet.Length; i++)
{
    if (Char.IsDigit(alphabet[i]))
    {
        numbers += alphabet[i];
    }
    else
    {
        characters.Append(alphabet[i]);
    }
}
for (int i = 0; i < characters.Length - 1; i++)
{
    for (int j = i + 1; j < characters.Length; j++)
    {
        if (!check(characters[i], characters[j]))
        {
            char y = characters[i];
            characters[i] = characters[j];
            characters[j] = y;
        }
    }
}
char[] chars = numbers.ToCharArray();
Array.Sort(chars);
Console.Write(characters);
Console.Write(chars);