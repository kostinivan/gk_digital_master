int[,] createIntArray(int N, int M, int minVal, int maxVal){
    Random rnd = new Random();
    int[,] result = new int[N,M];
    for (int i = 0; i < N ; i++){
        for (int j = 0; j < M ; j++){
            result[i,j] = rnd.Next(minVal, maxVal);
        }
    }
    return result;
}

void printIntArray(int[,] input){
    for (int i = 0; i < input.GetLength(0); i++){
        Console.Write(input[i,0]);
        for (int j = 1; j < input.GetLength(1); j++){
            Console.Write(" " + input[i,j]); 
        }
        Console.WriteLine("");
    }
    Console.WriteLine();
}

double[,] createDoubleArray(int N, int M, double minVal, double maxVal){
    Random rnd = new Random();
    double[,] result = new double[N,M];
    for (int i = 0; i < N ; i++){
        for (int j = 0; j < M ; j++){
            result[i,j] = rnd.NextDouble()*(maxVal - minVal) + minVal;
        }
    }
    return result;
}

void printDoubleArray(double[,] input){
    for (int i = 0; i < input.GetLength(0); i++){
        Console.Write(Math.Round(input[i,0], 2));
        for (int j = 1; j < input.GetLength(1); j++){
            Console.Write(" " + Math.Round(input[i,j], 2)); 
        }
        Console.WriteLine("");
    }
    Console.WriteLine();
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("I can create double array.");
// Console.Write("Number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Numbers of columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("min value of array: ");
// double minn = Convert.ToInt32(Console.ReadLine());
// Console.Write("MAX value of array: ");
// double maxx = Convert.ToInt32(Console.ReadLine());

// printDoubleArray(createDoubleArray(rows, cols, minn, maxx));

// Задача 50. Напишите программу, которая на 
// вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> элемента с такими индексами в массиве нет

// Console.WriteLine("I've made an array and can show you any element.");
// int N = 14;
// int M = 12;
// double [,] arra = createDoubleArray(14, 12, 5, 12);
// Console.Write("Give me index of row: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Give me index of col: ");
// int j = Convert.ToInt32(Console.ReadLine());
// if (i < M && j < N){
//     Console.WriteLine("Your element is " + Math.Round(arra[i, j], 2));
// } else {
//     Console.WriteLine("Sorry. I've missed the array. Try again");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] avarages2DArray(int[,] input){
    double[] result = new double[input.GetLength(1)];
    for (int j = 0; j < input.GetLength(1); j++){
        for (int i =0; i < input.GetLength(0); i++){
            result[j] += input[i,j];
        }
        result[j] /= input.GetLength(0);
    }
    return result;
}


Console.WriteLine("I can calculate average among cols.");
Console.Write("Give me the number of rows: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Give me the number of cols: ");
int M = Convert.ToInt32(Console.ReadLine());
int[,] aray = createIntArray(N, M, -10, 10);
Console.WriteLine("I've made an array: ");
printIntArray(aray);
Console.WriteLine("Your averages among cols: ");
double[] tmp = avarages2DArray(aray);
for (int i = 0; i < tmp.Length; i++){
    Console.Write(Math.Round(tmp[i], 2) + " ");
}



