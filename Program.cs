/*
Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
double[,] CreateRandom2dArray(int rows, int colums) 
{
    double[,] array = new double [rows,colums];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble() + new Random().Next(-10,10);
            array[i,j] = Math.Round(array[i,j],2);
        }
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк в массиве");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массиве");
int colums = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows,colums);
Show2dArray(myArray); 
*/

/*
Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/

/*
void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int GetElementFromPosition(int[,] array, int row, int column)
{
    if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        return array[row, column];
    else
        return -1;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите кол-во строк массива: ");
int columns = GetInput("Введите кол-во столбцов массива: ");
int[,] array = Create2dArray(rows, columns, 1, 9);

Console.WriteLine("Двумерный массив: ");
Print2dArray(array);

int row = GetInput("Введите номер строки элемента: ");
int column = GetInput("Введите номер столбца элемента: ");
int index = GetElementFromPosition(array, row, column);

if (index != -1)
    Console.WriteLine($"Значение элемента на позиции ({row}, {column}): {index}");
else
    Console.WriteLine("Такого элемента нет в массиве.");
*/

/*
Задача 3. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
                array[i,j] = new Random().Next(minValue,maxValue + 1);
        }
        return array;
} 

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticColumns(int[,] array, int columns, int rows)
{
double[] cols = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        sum += array[i, j];
        double colsMeans = sum / rows;
        cols[j] = colsMeans;
        Console.WriteLine("Среднее арифметическое каждого столбца " + (j + 1) + " = " + colsMeans);
    }
    return cols;
}

Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальную велечину: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную велечину: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);

Console.WriteLine();

ArithmeticColumns(myArray, columns, rows);
*/