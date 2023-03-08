int[] array = { 1, 7, 2, 12, 31, 4, 18, 15, 16, 17, 2, 7, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}
