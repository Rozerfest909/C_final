string ReadString(string msg) // Ввод сообщения
{
    System.Console.Write($"{msg} > ");
    return Console.ReadLine();
}

string[] CreateArray(int i, string[] array) // Заполнение массива
{
    string message = ReadString($"Введете элемент массива № {i + 1} ");
    if(i >= 9 && message != "Флюгегехаймен")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Вы уже ввели {i+1} значений. Напоминаю, что бы остановить ввод введите стоп-слово > Флюгегехаймен ");
        Console.ResetColor();
    }
    if (message != "Флюгегехаймен")
    {
        array[i] = message;
        i++;
        return CreateArray(i, CopyArray(array));
    }
    else
    {
        return array;
    }
}

string[] CopyArray(string[] array) // Увеличение размера массива на 1 слот (методом копирования)
{
    string[] new_array = new string[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        new_array[i] = array[i];
    }
    return new_array;
}

string[] CreateArrayFilter(string[] array)  //  Отбор элементов, длина которых меньше, либо равна 3 символам.
{
    string[] new_array = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i].Length <= 3 && array[i].Length > 0)
        {
            new_array[j] = array[i];
            j++;
        }
    }
    return new_array;
}

void PrintArray(string[] array) // Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int i = 0;
string[] array = new string[1];

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Для остановки заполнения массива, введите стоп-слово > Флюгегехаймен ");
Console.ResetColor();

string[] filled_array = CreateArray(i, array);
Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Cтоп-слово принято.");
Console.ResetColor();

Console.WriteLine($"Ваш массив > ");
PrintArray(filled_array);
Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Отбираем элементы длина которых меньше, либо равна 3 символам.");
Console.ResetColor();

Console.WriteLine($"Новый массив > ");
PrintArray(CreateArrayFilter(filled_array));