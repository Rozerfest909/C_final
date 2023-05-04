// // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string ReadString(string msg) // Ввод сообщения
{
    System.Console.Write($"{msg} > ");
    return Console.ReadLine();
}

string[] CreateArray(int i, string[] array) // Заполняем массив
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

string[] CopyArray(string[] array) // Увеличиваем размер массива на 1 слот (методом копирования)
{
    string[] new_array = new string[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        new_array[i] = array[i];
    }
    return new_array;
}

string[] CreateArrayFilter(string[] array)  //  Отбираем элементы, длина которых меньше, либо равна 3 символам.
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
Console.WriteLine("Для остановки заполненя массива введите стоп-слово > Флюгегехаймен ");
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