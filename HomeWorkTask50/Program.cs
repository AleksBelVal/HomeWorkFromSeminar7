// Программа принимает на вход позиции элемента в двумерном массиве,
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Пример, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

System.Console.WriteLine("\n Массив со случайными числами:\n");
int height = 3;
int width = 4;
int[,] array = new int[height, width];
Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(99);
        System.Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine
($"\nУкажите позицию элемена в массиве:");
System.Console.Write("по высоте: ");
int indexHeight = int.Parse(Console.ReadLine());
System.Console.Write("по ширине: ");
int indexWidthe = int.Parse(Console.ReadLine());
if (indexHeight < 3 && indexWidthe < 4)
{
    System.Console.Write("На данной позиции находится число: ");
    System.Console.WriteLine(array[indexHeight, indexWidthe]);
}
else
{
    System.Console.WriteLine("Элемента, с такими параметрами, в массиве - нет");
}
