/* Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
Console.WriteLine("Hello, World!");*/
//Задание двумерного массива для решения задачи
int[,] matrix2D = new int[3, 4] {{1,4,7,2},
                               {5,9,2,3},
                               {8,4,2,4}
                               };
void PrintArray(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            Console.Write($"{arr[m, n]}  ");
        }
        Console.WriteLine();
    }
}
PrintArray(matrix2D);
//Метод ввода числа для проверки в массиве
int GetNumber(string message)
{
    int res;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out res))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return res;
}
int number = GetNumber($"Введите число для проверки, есть это число в массиве или нет:");
//Метод проверки, есть ли такой элемент в массиве:
void CheckArrayForNumberIn(int[,] arr, int num)
{
    int position = -1;  // Случай, когда число не вхоит в массив
    int rowIndex = 0;
    int columnIndex = 0;
    for (int m = 0; m < 3; m++)
    {
        for (int n = 0; n < 4; n++)
        {
            if (arr[m, n] == num)
            {
                rowIndex = m;
                columnIndex = n;
                position = 0;
            }

        }
    }
    
    if (position == 0)
    {
        Console.WriteLine($"Число {num} - есть в массиве, например на позиции({rowIndex},{columnIndex})");
    }
    else
    {
        Console.WriteLine($"Число {num} -> такого числа в массиве нет");
    }
}
CheckArrayForNumberIn(matrix2D, number);