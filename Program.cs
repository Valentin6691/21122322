string[] array = {"if", "console", "for", "12345", "000", "78654", "+A"};
Console.WriteLine($"[{String.Join(',', array)}]");
ArrayConversion(array);

void ArrayConversion(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    int length = arr[i].Length;
        if(length < 4)
        {
            Console.Write(arr[i] + ",");
        }
        else
        {
            arr[i] = "";
        }
    }
}