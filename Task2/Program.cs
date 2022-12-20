/* Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

//Метод ввода количества строк/столбцов/позиций элемента
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }
    return result;
}
//Метод инициализации 2D массива
int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
//Метод печати массива
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
//Задание количества строк/столбцов, печать массива
int rownum = GetNumber("Введите количество строк массива:");
int colnum = GetNumber("Введите количество столбцов массива:");
int[,] array2D = InitMatrix(rownum, colnum);
Console.WriteLine($"Получена матрица ({rownum} x {colnum}):");
PrintArray(array2D);

//Вызов  элемента по заданным строке и столбцу
int askrownum = GetNumber("Введите номер строки элемента массива:");
int askcolnum = GetNumber("Введите номер столбца элемента массива:");
if (askrownum > 0 && askrownum <= array2D.GetLength(0)
 && askcolnum > 0 && askcolnum <= array2D.GetLength(1))
{
    Console.WriteLine($"Строка {askrownum}, столбец {askcolnum} - число {array2D[askrownum - 1, askcolnum - 1]}");
}
else
{
    Console.WriteLine($" Строка {askrownum}, столбец {askcolnum} -> такого числа в массиве нет");
}