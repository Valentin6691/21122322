string[] array = {"if", "console", "for", "12345", "000"};
Console.WriteLine($"[{String.Join(',', array)}]");

    for (int i = 0; i < array.Length; i++)
    {
    int length = array[i].Length;
        if(length < 4)
        {
            Console.Write(array[i] + " ");
        }
        else
        {
            array[i] = "";
    }
}