// Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента
//  в двумерном массиве, и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
// 4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
// 2, 3 -> такой элемент есть и равен 4
// 5, 5 -> такой элемент отсутствует
Console.WriteLine("Введите число строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int column = Convert.ToInt32(Console.ReadLine());
int [,] massive = new int [line,column];
Console.WriteLine();
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
            massive[i,j] = new Random().Next (-10, 10);
        }
    }
}

FillArray(massive);
PrintArray(massive);
Console.WriteLine();

void FindNumber(int[,] massive)
{
Console.WriteLine("Введите число которое хотите проверить");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (number == massive[i,j]) 
            {
                Console.WriteLine($"{number} -> такое число в массиве есть, имеет индекс ({i},{j})");
                count++;
            }
                
        } 
       
    }
if (count==0) Console.WriteLine ($"{number} -> такого числа нет в массиве"); 
} 
     
FindNumber(massive);
  

