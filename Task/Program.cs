void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10, 10);
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

string CreateNewArray(int[] array)
{
    string res = string.Empty;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
        {
            res += $"{array[i]} ";
        }
    }
    return res;
}


int[] array = new int[5];
int[] newArray = new int[5];
FillArray(array);
Console.WriteLine(PrintArray(array));
Console.WriteLine(CreateNewArray(array));
