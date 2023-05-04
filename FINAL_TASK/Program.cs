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

    if (message != "1")
    {
        array[i] = message;
        i++;
        // PrintArray(array);
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
        if (array[i].Length <= 3)
        {
            new_array[j] = array[i];
            j++;
            // PrintArray(new_array);
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
string[] filled_array = CreateArray(i, array);
PrintArray(filled_array);

PrintArray(CreateArrayFilter(filled_array));