// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("_____________");

double[,] array = new double[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0, 10);
        // array[i,j] = new Random().Next(1000, 100000);
        // array[i,j] = array[i,j] / 1000;
        Console.Write(array[i,j]+ " ");
        // array[i,j] = Math.Round(new Random().NextDouble(), 3) + new Random().Next(0,100);
        // Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("_____________");

double colum = 1;
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i,j];
    }
    Console.WriteLine($"Сумма в столбце {colum} равна {sum}");
    colum = colum + 1;
}