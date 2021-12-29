void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10,10);
    }
}

string PrintArray(int[] array)
{
    string result = string.Empty;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        result += $"{array[i]} ";
    }
    return result;
}

int[] array = new int[5];
FillArray(array);
Console.WriteLine(PrintArray(array));
