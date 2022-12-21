/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

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
int[,] InitArray(int m, int n)
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
void PrintArray(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            Console.Write($"{arr[j, k]}  ");
        }
        Console.WriteLine();
    }
}
//Метод для нахождения среднего арифметического каждого столбца:
void GetColumnArithmetMean(int[,] matrix)
{    
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double sumColumn = 0;
            double arithMean = 0; 
            int indexCol = 0; 
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                sumColumn += matrix[k,j];
                arithMean = sumColumn / matrix.GetLength(0);
                indexCol = j;
            }
            Console.WriteLine($"Среднее арифметическое  столбца {indexCol + 1} равно {Math.Round(arithMean,1, MidpointRounding.ToZero)} ");
        }
    }
}
int[,] array2D = InitArray(GetNumber("Введите количество строк массива:"), GetNumber("Введите количество столбцов массива:"));
Console.WriteLine("Задан массив:");
PrintArray(array2D);
GetColumnArithmetMean(array2D); 