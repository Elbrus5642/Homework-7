/* 8 Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
//Методы задания  количества строк и столбцов массива int GetArrayRowsNumber(string message)
int GetArrayRowsNumber(string message)
{
    int rowNum;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out rowNum))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return rowNum;
}
int GetArrayColumnNumber(string message)
{
    int columNum;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out columNum))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return columNum;
}
// Метод заполнения массива случайными вещестенными числами
void FillRealArray(double[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((rnd.Next(-10, 10) + rnd.NextDouble()),2);
        }
    }
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int rowNumbers = GetArrayRowsNumber($"Введите количество строк массива");
int columnNumbers = GetArrayColumnNumber(($"Введите количество строк массива"));
double[,] matrix = new double[rowNumbers, columnNumbers];
FillRealArray(matrix);
PrintArray(matrix);