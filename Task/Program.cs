void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10,10);
    }
}

int[] array = new int[5];
FillArray(array);