/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] array2D = new int[3, 4] {{1,4,7,2},
                               {5,9,2,3},
                               {8,4,2,4}
                               };
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
PrintArray(array2D);
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
            Console.WriteLine($"Среднее арифметическое {indexCol + 1} столбца  равно {Math.Round(arithMean,1, MidpointRounding.ToZero)} ");
        }
    }
}
GetColumnArithmetMean(array2D); 