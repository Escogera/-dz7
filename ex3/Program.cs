// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] massive = new int [line ,column];
void PrintArray (int [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i,j] = new Random().Next (0, 10);
        }
    }
}

FillArray(massive);
PrintArray(massive);

void FindAverage(int[,] massive)
{
    for(int j = 0; j < column; j++)
    {
        double sum = 0;
        double avarage = 0;
        for(int i = 0; i < line; i++)
        {
            sum = (sum + massive[i,j]);
        }
        avarage = sum/line;
        Console.WriteLine($"Среднее арифметическое столбца {j+1} равно: {Math.Round(avarage,1)}");
    }
}
Console.WriteLine();
FindAverage(massive);