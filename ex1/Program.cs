// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int column = Convert.ToInt32(Console.ReadLine());
double [,] massive = new double [line,column];
Console.WriteLine();
void PrintArray (double [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            double doubleNumber = Math.Round(massive[i, j], 1);
            Console.Write(doubleNumber + "  ");
        }
        Console.WriteLine();
    }
}

void FillArray(double [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i,j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

FillArray(massive);
PrintArray(massive);