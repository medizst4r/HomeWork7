/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
double[,] CreatRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    double[,] array = new double[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1)
            + new Random().NextDouble();
    return array;
}
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0 && array[i, j] < 10)
                Console.Write($"{Math.Round(array[i, j], 2)}  ");
            if (array[i, j] > -10 && array[i, j] < 0)
                Console.Write($"{Math.Round(array[i, j], 2)}  ");
            if (array[i, j] >= 10)
                Console.Write($"{Math.Round(array[i, j], 2)}  ");
            if (array[i, j] <= -10)
                Console.Write($"{Math.Round(array[i, j], 2)}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Show2dArraySimple(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 2) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value");
int max = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreatRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine();
Show2dArraySimple(myArray);
*/
/*
Задача 50.
 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/
/*
void ShowElements(int[,] array, int a, int b)
{
    if (a <= array.GetLength(0) && b <=array.GetLength(1) )
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if(i ==a && j==b) 
           Console.Write($" Element with rows {a} and columns {b} is {array[i,j]}");
        }  
    }
    }
    else Console.WriteLine("This element is not in the array .");
}
int[,] CreatRandom2dArray()
{
    int rows = new Random().Next(2, 10);
    int colums = new Random().Next(2, 10);
    int minValue = new Random().Next(-50, -10);
    int maxValue = new Random().Next(10, 50);
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Input a position element of row");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a position element of columns");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreatRandom2dArray();
Show2dArray(myArray);
ShowElements(myArray, m, n);
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
double[] AverageOfEachColumn(int[,] array)

{
    double[] arr = new double[array.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = (sum + array[i, j]);
        }
        arr[j] = sum/array.GetLength(0);     
    }
    return arr;
}

int[,] CreatRandom2dArray()
{
    int rows = new Random().Next(4, 4);
    int colums = new Random().Next(5, 5);
    int minValue = new Random().Next(-10, -10);
    int maxValue = new Random().Next(10, 10);
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0 && array[i, j] < 10)
                Console.Write($" {array[i, j]}   ");
            if (array[i, j] > -10 && array[i, j] < 0)
                Console.Write($"{array[i, j]}   ");
            if (array[i, j] >= 10)
                Console.Write($" {array[i, j]}  ");
            if (array[i, j] <= -10)
                Console.Write($"{array[i, j]}  ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)

        Console.Write(Math.Round(array[i],2) + "   ");

    Console.WriteLine();
}
int[,] myArray = CreatRandom2dArray();
Show2dArray(myArray);

Console.WriteLine();

double[] arr = AverageOfEachColumn(myArray);
ShowArray(arr);
*/