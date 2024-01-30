Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] myArray = new int[size, size];
Random rank = new Random();
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = rank.Next(-10, 10);
        Console.Write(myArray[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Какое действие выполнить : " +
    "\n 1 - Найти количество положительных/отрицательных чисел в матрице\r" +
    "\n 2 - Сортировка элементов матрицы построчно (в двух направлениях)\r" +
    "\n 3 - Инверсия элементов матрицы построчно");
int action = int.Parse(Console.ReadLine());
switch (action)
{
    case 1:
        NumericalValue(myArray);
        break;

    case 2:
        Console.WriteLine("Какую сортировку выполнить?: " +
        "\n 1 - Положительную\r " +
        "\n 2 - Отрицательную\r ");
        int sortArray = Convert.ToInt32(Console.ReadLine());
        SortingItems(myArray, sortArray);
        break;

    case 3:
        Inversion(myArray);
        break;
}
static void NumericalValue(int[,] array)
{
    int countPositive = 0;
    int countNegative = 0;
    int zero = 0;
    foreach (int item in array)
    {
        if (item > 0)
            countPositive++;

        else if (item < 0)
            countNegative++;
        else if (item == 0)
            zero++;
    }

    Console.WriteLine($"Количество положительных чисел в массиве {countPositive}");
    Console.WriteLine($"Количество отрицательных чисел в массиве {countNegative}");
    Console.WriteLine($"Количество нолей в массиве {zero}");
}
static void SortingItems(int[,] array, int sort)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int c = j + 1; c < array.GetLength(1); c++)
            {
                if (sort == 1)
                {
                    if (array[i, j] > array[i, c])
                    {
                        result = array[i, j];
                        array[i, j] = array[i, c];
                        array[i, c] = result;
                    }
                }
                else
                {
                    if (array[i, j] < array[i, c])
                    {
                        result = array[i, j];
                        array[i, j] = array[i, c];
                        array[i, c] = result;

                    }
                }
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
static void Inversion(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
