int n = int.Parse(Console.ReadLine());
int[] first = new int[n];
int[] second = new int[n];
for (int i = 0; i < n; i++)
{
    first[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    second[i] = int.Parse(Console.ReadLine());
}
for (int i = 0;i < n; i++)
{
    Console.WriteLine(first[i] * second[i]);
}