string InputAny(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] CreateArray(int size)
{
    return new string[size];
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputAny("Введите значение ячейки: ");
    }
}

void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length-1) System.Console.Write(", ");
        else System.Console.WriteLine("]");
    }

}

int Less3Count(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            counter++;
    }
    return counter;
}

void SortArrayByString(string[] array)
{
    string[] resultArray = CreateArray(Less3Count(array));
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    PrintArray(resultArray);
}


    while (true)
    {
        Console.Clear();
        Console.WriteLine("Массив строк, вывести новый массив, который состоит из строк основного массива длинною 3 символа и менее.");
        int size;
        try
        {
            size = int.Parse(InputAny("Введите размер массива: "));
        }
        catch (Exception)
        {
            Console.WriteLine("Вы ввели неверное значение!");
            Console.ReadLine();
            continue;
        }

        string[] array = CreateArray(size);
        FillArray(array);
        PrintArray(array);
        Console.WriteLine("Результирующий массив:");
        SortArrayByString(array);



        Console.ReadLine();
    }