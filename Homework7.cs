//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] Array(int m, int n) {
//     double[,] array = new double[m, n];
//     for (int i = 0; i < m; i++) {
//         for (int j = 0; j < n; j++) {
//             double randomNumber = new Random().NextDouble();
//             array[i, j] = Convert.ToDouble(randomNumber.ToString("0.00"));
//         }
//     }
//     return array;
// }

// void Print (double[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++) {
//         for (int j = 0; j < array.GetLength(1); j++) {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Input size of rows");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input size of columns");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = Array(m, n);
// Print(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.

// int[,] array = new int[3, 3];
// for (int i = 0; i < array.GetLength(0); i++) {
//     for (int j = 0; j < array.GetLength(1); j++) {
//         array[i, j] = new Random().Next(0, 10);
//     }
// }

// void PrintArray (int[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++) {
//         for (int j = 0; j < array.GetLength(1); j++) {
//             System.Console.Write(array[i, j] + " ");
//     }
//         System.Console.WriteLine();
//     }
// }

// PrintArray(array);
// System.Console.WriteLine();
// System.Console.WriteLine("Input coords");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > array.Length || b > array.Length) {
//     System.Console.WriteLine("Invalid coords");
// } else {
//     object c = array.GetValue(a, b);
//     System.Console.WriteLine($"The element is -> {c}");
// }

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Array (int m, int n) {
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
        array[i, j] = new Random().Next(0, 10);
    }
}
return array;
}

void PrintArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write(array[i, j] + " ");
    }
        System.Console.WriteLine();
    }
}

void PrintSecArray (double[] array) {
    for (int i = 0; i < array.Length; i++) {
            System.Console.Write(array[i] + " ");
    }
        System.Console.WriteLine();
}

System.Console.WriteLine("Input array size");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = Array(m, n);

double[] average = new double[n];
for (int j = 0; j < n; j++) {
    double sum = 0;
    for (int i = 0; i < m; i++) {
        sum += array[i, j];
    }
    average[j] = sum / m; // делим на кол-во строк в столбце
}

PrintArray(array);
PrintSecArray(average);