
#region Задание 1
for (int i = 0; i < 100; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
#endregion

#region Задание 2
for (int i = 5; i > 0; i--)
{
    Console.WriteLine(i);
}
#endregion
#region Задание 3
Console.WriteLine("Введите число :");
int value = Convert.ToInt32(Console.ReadLine());
int valueResult = 0;
for (int i = 1; i <= value; i++)
{
    valueResult += i;
}
Console.WriteLine(valueResult);


#endregion
#region Задание 4


int a = 0;

while (a < 100)
{
    a++;
    if (a % 7 == 0)
    {
        Console.WriteLine(a);
    }
}

#endregion
#region Задание 5
int[] array1 = new int[5];
int[] array2 = new int[5];

FillArray(array1);
FillArray(array2);

CalculateArithmeticaMean(array1, array2);

//int sum = 0;
//Console.WriteLine("Введите данные массива №1 через 'пробел'");
//string[] arrayNumber = Console.ReadLine().Split(' ');

//Console.WriteLine("Введите данные массива №2 через 'пробел'");
//string[]arrayNumber2 = Console.ReadLine().Split(' ');

//for (int i = 0; i < arrayNumber.Length; i++)
//{
//    array1[i] = int.Parse(arrayNumber[i]);
//}
//for (int i = 0;i < arrayNumber2.Length; i++)
//{
//    array2[i] = int.Parse(arrayNumber2[i]);
//}

//for(int i = 0;i< array1.Length; i++)
//{
//    sum += array1[i];
//}
//int result = sum / array1.Length;

//sum = 0;

//for (int j = 0; j < array2.Length; j++)
//{

//    sum += array2[j];
//}
//int result2 = sum / array2.Length;


//if (result > result2)
//{
//    Console.WriteLine($"Средне арифметическое массива №1 равно {result}");
//}
//else if (result < result2)
//{
//    Console.WriteLine($"Средне арифметическое массива №2 равно {result2}");
//}
//else if (result == result2)
//{
//    Console.WriteLine($"Средне арифметическое массивов равны");
//}

static void FillArray( int[] array)
{
    Console.WriteLine("Введите данные массива ");

    int filledNumbers = 0;

    while (true)
    {
        if (filledNumbers == 5)
        {
            break;
        }

        var numberStr = Console.ReadLine();

        if (string.IsNullOrEmpty(numberStr) || string.IsNullOrWhiteSpace(numberStr))
        {
            Console.WriteLine("Введите число");

            continue;
        }

        if (!int.TryParse(numberStr, out var number))
        {
            Console.WriteLine("Введите числовое значение");

            continue;
        }

        array[filledNumbers] = number;

        filledNumbers++;
    }
}

static void CalculateArithmeticaMean(int[] array1, int[] array2)
{
    var firstSum = 0;
    var twiceSum = 0;

    for (int i = 0; i < array1.Length; i++)
        firstSum += array1[i];

    firstSum /= array1.Length;

    for (int j = 0; j < array2.Length; j++)
        twiceSum += array2[j];

    twiceSum /= array2.Length;

    if (firstSum > twiceSum)
    {
        Console.WriteLine($"Средне арифметическое массива №1 равно {firstSum}");
    }
    else if (firstSum < twiceSum)
    {
        Console.WriteLine($"Средне арифметическое массива №2 равно {twiceSum}");
    }
    else if (firstSum == twiceSum)
    {
        Console.WriteLine($"Средне арифметическое массивов равны");
    }


}

#endregion