// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] findArray = new int[rows, colums];
for (int i = 0; i < findArray.GetLength(0); i++)
{
    for (int j = 0; j < findArray.GetLength(1); j++)
    {
        findArray[i,j] = new Random().Next(0,10);
        Console.Write(findArray[i,j] + " ");
    }
    Console.WriteLine();
}

int count = 0;
Console.WriteLine("Введите число, которое необходимо найти");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < findArray.GetLength(0); i++)
{
    for (int j = 0; j < findArray.GetLength(1); j++)
    {
        if(num == findArray[i,j])
        {
            count = count + 1;
        }
    }
}

if (count >= 1)
{
    Console.WriteLine($"В массиве {count} чисел {num}");
}

else
{
    Console.WriteLine($"В массиве нет чисел {num}");
}
