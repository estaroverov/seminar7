// Functions

void PrintArray(double[] arr)
{
    Console.WriteLine();
    foreach (double i in arr)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

void PrintMatrix(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
}

void PrintIntMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
}
// Функция ко второй задаче
void PrintElement(double[,] matrix, int row, int column)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    if (row >= rows || column >= cols)
        Console.WriteLine("Такого элемента не существует");
    else
        Console.WriteLine($"Значение элемента [{row},{column}]:" + matrix[row, column]);
}

double[,] InitRandomDoubleMatrix(int rows, int cols, int diap)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            matrix[i, j] = Math.Round(new Random().NextDouble() * diap - new Random().NextDouble() * diap, 1);
    }
    return matrix;
}
int[,] InitRandomIntMatrix(int rows, int cols, int min = 0, int max = 100)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            matrix[i, j] = new Random().Next(min, max);
    }
    return matrix;
}

// Функция к третьей задаче
double[] AvgColumns(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    double[] avgArr = new double[cols];
    int counterCols = 0;
    double sum = 0;

    while (counterCols < cols)
    {
        sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, counterCols];
        }
        avgArr[counterCols] = Math.Round(sum / cols, 1);
        counterCols++;
    }

    return avgArr;
}

// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] matrix = InitRandomDoubleMatrix(3, 4, 20);
PrintMatrix(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Матрица задачи номер 2:");
double[,] matrix2 = InitRandomDoubleMatrix(4, 4, 20);
PrintMatrix(matrix2);
Console.WriteLine("Введите позицию элемента:");
string positionString = Console.ReadLine();
int row = int.Parse(positionString.Split()[0]);
int column = int.Parse(positionString.Split()[1]);
PrintElement(matrix2, row, column);

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Дана матрица:");
int[,] matrix3 = InitRandomIntMatrix(4, 4);
PrintIntMatrix(matrix3);
double[] avgArr = AvgColumns(matrix3);
Console.WriteLine("Массив средних значений колонок:");
PrintArray(avgArr);