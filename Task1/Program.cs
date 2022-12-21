/* 8 Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
//Методы задания  количества строк и столбцов массива int GetArrayRowsNumber(string message)
int GetNumber(string message)
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

// Метод заполнения массива случайными вещестенными числами
void InitRealArray(double[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((rnd.Next(-10, 10) + rnd.NextDouble()),1);
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

int rowNum = GetNumber($"Введите количество строк массива");
int columnNum = GetNumber(($"Введите количество строк массива"));
double[,] matrix = new double[rowNum, columnNum];
InitRealArray(matrix);
PrintArray(matrix);