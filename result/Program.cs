// Написать программу, которая из имеющегося массива 
// строк формирует массив из строк, длина которых 
// меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
int counter = 0;

string[] CreateFirstArray(int len)
{
    string[] arr = new string[len];
    int i = 0;
    while (i < arr.Length)
    {
        Console.Write("Введите текст для элемента входного массива: ");
        arr[i] = Console.ReadLine();
        if (arr[i].Length <= 3) counter++;
        i++;
    }
    return arr;
}

void PrintArray(string[] arr)
{
    foreach (string item in arr)
    {
        Console.Write($"{item} ");
    }
    if (arr.Length == 0) Console.Write("[]");
    Console.WriteLine();
}

string[] CreateSecondArray(string[] arr)
{
    int j = 0;
    string[] result = new string[counter];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[j] = arr[i];
            j++;
        }
    }
    return result;
}

// 1. Указываем размерность входного массива
Console.Write("Введите размерность входного массива arrIn: ");
int lenIn = Convert.ToInt32(Console.ReadLine());

// 2. задаем массив и элементов, введенных вручную
string[] arrIn = CreateFirstArray(lenIn);

// 3. Печатаем входной массив
PrintArray(arrIn);

//4. Создаем и заполняем выходной массив
string[] arrOut = CreateSecondArray(arrIn);

//5. Печатаем выходной массив
PrintArray(arrOut);


