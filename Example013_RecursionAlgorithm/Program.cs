// string [,] table = new string [2, 5]; // определяем таблицу
// // индексы строк и столбцов с нуля отсчитываются
// // String.Empty инициализация для строк происходит такой константой
// // table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// // table [1,0] table [1,1] table [2,2] table [3,3] table [4,4]

// table[1, 2] = "слово"; // обращаемся к нужному элементу, сначала индекс строки, потом столбца. далее работаем как и ранее, как будто это обычная переменная

// // используем цикл для того, чтобы распечатать массив
// for (int rows = 0; rows < 2; rows++) // количество строк не больше 2
// {
//     for(int columns = 0; columns < 5; columns++) // вложенный цикл, количество строк
//     {
//         Console.WriteLine($"-{table[rows, columns]}-"); // распечатываем массив, интерполяция, обращение через название и строки/столбцы
//     // добавили два знака минус справа и слева от фигурных скобок, чтобы строки инициализировались, они пустые
//     }
// }

// int[,] matrix = new int[3, 4]; // определяем двумерный массив с числами, называем его матрикс

// void PrintArray(int[,] matr); // вместо аргумента передаем прямоугольную таблицу чисел
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // внешний цикл по i - строки, внутренний по j - столбцы
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// i < matrix.GetLength(0) ноль это количество строк, то есть 3
// j < matrix.GetLength(1) выдает 4 столбика


void PrintArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
 }
}
void FillArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 matr[i,j] = new Random().Next(1,10);//[1; 10)
 }
 }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);