// Первая группа методов

void Metod1()
{
    Console.WriteLine("Автор …");
}
// Metod1();

void Metod2(string msg) // где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.
{
    Console.WriteLine(msg); // оператор, в скобках указан принятый аргумент.
}
// Metod2("Текст сообщения"); //где Metod2 является идентификатором, а в скобках указан текст, выводимый в консоли.

// Именованные аргументы
void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); // где переменная count отображает на экране определённое количество сообщений msg.
        i++;
    }
}
// Metod21("Текст", 4); // метод вызывает Текст, после запятой указано количество вызовов, в нашем случае 4.

// Третья группа методов
int Method3() //не принимает никакие аргументы
{
    return DateTime.Now.Year; //обязательное использование оператора return,
}
int year = Method3(); // вызываем метод, в левой части используем идентификатор переменной (year) и через оператор присваивания (=) кладём нужное значение

// Console.WriteLine(year);

// Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) // вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    {
        result = result + text;
    }
    return result;
}
// string res = Method4(10, "z");
// // Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// ======= Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012
// // s[3] // r        


// string Replace(string text, char oldValue, char NewValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{NewValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1 ; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array [i];
        array[i] = array [minPosition];
        array[minPosition] = temporary;
        
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);