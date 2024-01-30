// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// void PrintNumbers(int m, int n)
// {
//     if (m <= n)
//     {
//         Console.Write($"{m} ");
//         PrintNumbers(m + 1, n);
//         return;
//     }
// }

// Console.Clear();
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// PrintNumbers(m, n);

// ----------------------------------------------------------------------------------------------

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// Console.Clear();
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// AkkermanFunction(m,n);

// ----------------------------------------------------------------------------------------------

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// void PrintArray(int[] arr, int index)
// {
//     if (index >= 0)
//     {
//         Console.Write($"{arr[index]} ");
//         PrintArray(arr, index - 1);
//     }
// }

// int[] arr = {1, 2, 5, 6, 10, 34};
// PrintArray(arr, arr.Length - 1);