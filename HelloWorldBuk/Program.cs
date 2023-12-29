string s = Console.ReadLine();
bool check = false;
for (int i = 0, j = s.Length - 1; i < s.Length/2 ; i++,j--)
{
    check = (s[i] == s[j]) ? true : false;
}
Console.WriteLine(check);