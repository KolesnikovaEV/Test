// Метод создания массива
int[] Create(int len)
{
    return new int[len];
}

// Метод печати массива
void Print(int[] array)
{
    int len = array.Length;
    int i = 0;
    while(i<len)
    {
        Console.Write($"{array[i],4}");
        i++;
    }
    Console.WriteLine();
}

// Метод заполнения массива
void Fill(int[] numbers)
{
    int index = 0;
    while(index<numbers.Length)
    {
        numbers[index] = new Random().Next(-10,11);
        index++;
    }
}

// Метод инвертирования массива
void Invert(int[] arr)
{
    int index = 0;
    while(index<arr.Length)
    {
        arr[index] = -arr[index];
        index++;
    }
}

int[] numbers = Create(10);
Fill(numbers);
Print(numbers);
Invert(numbers);
Print(numbers);