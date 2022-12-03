// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет




Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

CheckNumber(array, num);

void CheckNumber(int[,] array, int nums)
{
    int checknum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i, j])
            {
                checknum = num;
            }
        }
    }
    if (checknum == 0)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"Число {num}, есть в массиве");
    }
}

// Console.WriteLine($"Число {num}, есть в массиве");
// System.Console.WriteLine("Такого числа в массиве нет");