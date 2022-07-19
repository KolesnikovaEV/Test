// Задать массив из 8 элементов и вывести их на экран 

char[] CreateArray(int count)
{
    return new char[count];
}

void Print(char[] array)
{
    int len = array.Length;
    int i = 0;
    while(i<len)
    {
        Console.WriteLine(array[i]);
        i++;
    }
}

void Fill(char[] array)
{
    int length = array.Length;
    int i = 0;
    while(i<length)
    {
        array[i++] = Convert.ToChar(new Random(). Next(64, 64+22));

    }
}


char[] arg = CreateArray(8);
Fill (arg);
Print(arg);