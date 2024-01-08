string s = Console.ReadLine();
bool check = true;
for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
{
    if (s[i] != s[j])
    {
        check = false; break;
    }
}
Console.WriteLine(check);