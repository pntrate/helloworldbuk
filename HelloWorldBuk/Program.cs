string vowels = "aeiouAEIOU";
string s = Console.ReadLine();
for (int i = 0; i < s.Length; i++)
{
    if (vowels.Contains(s[i]))
    {
        s = s.Remove(i, 1);
        i--;
    }
}
Console.WriteLine(s);