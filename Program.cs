string[] array = {"if", "console", "for", "12345", "000", "78654", "+A"};
Console.WriteLine($"{String.Join(' ', array)}");
Console.WriteLine("Размер нового массива: " + SizeNewArray(array));
ArrayConversion(array, SizeNewArray(array));

int SizeNewArray(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    int length = arr[i].Length;
        if(length < 4)
        {
            size++;
        }
    }
    return size;
}

void ArrayConversion(string[] arr, int size)
{
    for (int i = 0; i < arr.Length; i++)
    {
    int length = arr[i].Length;
        if(length < 4)
        {
            string[] arr1 = new string[size];
            int j = 0;
            arr1[j] = arr[i];
            // j++;    
            Console.Write(arr1[j] + " ");
        }
    }
}
