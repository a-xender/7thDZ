// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("введите количество строк");
// int rows= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[rows, columns];

// FillArrayDoubleNumbers(numbers);
// PrintArray(numbers);

// void FillArrayDoubleNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().NextDouble()*10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{Math.Round(array[i, j],1)}   ");
//         }
//         Console.WriteLine();
//     }
// }


















// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// // 17 -> такого числа в массиве нет

// Console.WriteLine("введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[rows, columns];
// Console.WriteLine("Введите целое число для поиска в массиве");
// int findNumber = Convert.ToInt32(Console.ReadLine());


// FillArrayIntNumbers(numbers);
// PrintArray(numbers);
// FindPositionPositive(numbers);
// Console.Write(FindPositionNegative(numbers));



// void FillArrayIntNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 11);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// void FindPositionPositive(int[,] array)
// {



//     for (int i = 0; i < array.GetLength(0); i++)

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == findNumber)
//                 Console.WriteLine($"  Искомый элемент находится в {i + 1} строке  {j + 1} столбца ");

//         }


// }

// string FindPositionNegative(int[,] array)
// {
// string result="Искомого элемента нет в массиве";
// for (int i = 0; i < array.GetLength(0); i++)

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == findNumber)
//                 result="";

//         }
// return result;
// }














// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, columns];
FillArrayIntNumbers(numbers);
PrintArray(numbers);
Average(numbers);


void FillArrayIntNumbers(int[,] array)
{

    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 11);
            }
    }
}

void PrintArray(int[,] array)
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
void Average(int[,] array)
{
    Console.WriteLine("Среднее арифметическое каждого столбца: ");


    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{sum / (rows):F2} ; ");
    }
}
