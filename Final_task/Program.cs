// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“hello”, “2”, “world”, “:-)”] -> [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] -> [“-2”]
// [“Russia”, “Denmark”, “Kazan”] -> []


int n = ReadInt("Введите размер массива: ");
string[] inputAray = new string[n];
FillArray(inputAray);
System.Console.WriteLine();

System.Console.WriteLine($"Вы ввели массив:");
PrintArray(inputAray);

int sizeOutput = FindArraySize(inputAray);
System.Console.WriteLine();

System.Console.WriteLine($"Элементы, длина которых меньше, либо равна 3 символам:");
PrintArray(CreateResultArray(sizeOutput, inputAray));



int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(string[] array)
{
    System.Console.WriteLine("Введите элементы массива:");
    int length = array.Length;
    int i = 0;
    while (i < length)
    {
        array[i] = Console.ReadLine()!;
        i++;
    }
}

int FindArraySize(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            size++;
        }
    }
    return size;
}

string[] CreateResultArray(int size, string[] array)
{
    string[] resultArr = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArr[resultArr.Length - size] = array[i];
            size--;
        }
    }
    return resultArr;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}