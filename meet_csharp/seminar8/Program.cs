// int[,] createIntArray(int N, int M, int minVal, int maxVal){
//     Random rnd = new Random();
//     int[,] result = new int[N,M];
//     for (int i = 0; i < N ; i++){
//         for (int j = 0; j < M ; j++){
//             result[i,j] = rnd.Next(minVal, maxVal);
//         }
//     }
//     return result;
// }

// void printIntArray(int[,] input){
//     for (int i = 0; i < input.GetLength(0); i++){
//         Console.Write(input[i,0]);
//         for (int j = 1; j < input.GetLength(1); j++){
//             Console.Write(" " + input[i,j]); 
//         }
//         Console.WriteLine("");
//     }
//     Console.WriteLine();
// }

// double[,] createDoubleArray(int N, int M, double minVal, double maxVal){
//     Random rnd = new Random();
//     double[,] result = new double[N,M];
//     for (int i = 0; i < N ; i++){
//         for (int j = 0; j < M ; j++){
//             result[i,j] = rnd.NextDouble()*(maxVal - minVal) + minVal;
//         }
//     }
//     return result;
// }

// void printDoubleArray(double[,] input){
//     for (int i = 0; i < input.GetLength(0); i++){
//         Console.Write(Math.Round(input[i,0], 2));
//         for (int j = 1; j < input.GetLength(1); j++){
//             Console.Write(" " + Math.Round(input[i,j], 2)); 
//         }
//         Console.WriteLine("");
//     }
//     Console.WriteLine();
// }

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// void sort2DintArrayRows(int[,] input){
//     for (int i = 0; i < input.GetLength(0); i++){
//         bool bubble_done = false;
//         while (!bubble_done){
//             bubble_done = true;
//             for (int j = 0; j < input.GetLength(1) - 1; j++){
//                 if (input[i, j] < input[i, j + 1]){
//                     int c = input[i, j];
//                     input[i, j] = input[i, j + 1];
//                     input[i, j + 1] = c;
//                     bubble_done = false;
//                 }
//             }
//         }
//     }
// }

// Console.WriteLine("Hey! I can sort rows in 2d arrays.");
// Console.Write("Tell me the number of rows: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Tell me the number of cols: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[,] arrayToSort = createIntArray(N, M, 0, 10);
// Console.WriteLine("unsorted array was: ");
// printIntArray(arrayToSort);
// sort2DintArrayRows(arrayToSort);
// Console.WriteLine("sorted array is: ");
// printIntArray(arrayToSort);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int detectMinRowNum(int[,] input){
//     int min_sum = 0;
//     for (int j = 0; j < input.GetLength(1); j++){
//         min_sum += input[0,j];
//     }
//     int min_i = 0;
//     for (int i = 1; i < input.GetLength(0); i++){
//         int c_sum = 0;
//         for (int j = 0; j < input.GetLength(1); j++){
//             c_sum += input[i,j];
//         }
//         if (c_sum < min_sum){
//             min_i = i;
//         }
//     }
//     return min_i + 1;
// }

// Console.WriteLine("Hey! I detect row with mini sum of elements.");
// Console.Write("Tell me the number of rows: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Tell me the number of cols: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[,] arrayToCalc = createIntArray(N, M, 0, 10);
// Console.WriteLine("input array is: ");
// printIntArray(arrayToCalc);
// Console.WriteLine("the row with min sum of elements is: " + detectMinRowNum(arrayToCalc));


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// bool checkSizesForMult(int[,] lhs, int[,] rhs){
//     if (lhs.GetLength(1) == rhs.GetLength(0)){
//         return true;
//     }
//     return false;
// }

// int[,] multiply2D(int[,] lhs, int[,] rhs){
//     int[,] result = new int[lhs.GetLength(0), rhs.GetLength(1)];
//     for (int i = 0; i < lhs.GetLength(0); i++){
//         for (int j = 0; j < rhs.GetLength(1); j++){
//             result[i, j] = 0;
//             for (int k = 0; k < lhs.GetLength(1); k++){
//                 result[i, j] += lhs[i,k] * rhs[k,j];
//             }
//         }
//     }
//     return result;
// }

// Console.WriteLine("Hey! I can in matrix multiplication.");
// Console.Write("Tell me the number of rows 1st matrix: ");
// int N1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Tell me the number of cols 1st matrix: ");
// int M1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Tell me the number of rows 2nd matrix: ");
// int N2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Tell me the number of cols 2nd matrix: ");
// int M2 = Convert.ToInt32(Console.ReadLine());
// int[,] lhs = createIntArray(N1, M1, 0, 10);
// int[,] rhs = createIntArray(N2, M2, 0, 10);
// if (!checkSizesForMult(lhs, rhs)){
//     Console.WriteLine("I won't muliply this. Think about sizes.");
//     System.Environment.Exit(-1);
// }
// Console.WriteLine("input array #1 is: ");
// printIntArray(lhs);
// Console.WriteLine("input array #2 is: ");
// printIntArray(rhs);
// Console.WriteLine("the result of multiplication is: ");
// printIntArray(multiply2D(lhs, rhs));


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] create3DIntUniqueArray(int N, int M, int L, int minVal, int maxVal){
//     int[,,] result = new int[N,M,L];
//     Random rnd = new Random();
//     HashSet<int> used = new HashSet<int>();
//     for (int i = 0; i < N; i++){
//         for (int j = 0; j < M; j++){
//             for (int k = 0; k < L; k++){
//                 int new_val = rnd.Next(minVal, maxVal + 1);
//                 while (used.Contains(new_val)){
//                     new_val = rnd.Next(minVal, maxVal + 1);
//                 }
//                 result[i,j,k] = new_val;
//                 used.Add(new_val);
//             }
//         }
//     }
//     return result;
// }

// void print3Darray(int[,,] input){
//     for (int i = 0; i < input.GetLength(0); i++){
//         for (int j = 0; j < input.GetLength(1); j++){
//             for (int k = 0; k < input.GetLength(2); k++){
//                 Console.Write(input[i,j,k] + "(" + i + "," + j + "," + k + ") ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// bool dimensionValid(int N, int M, int K){
//     if (N*M*K < 100){
//         return true;
//     }
//     return false;
// }


// Console.WriteLine("Hey! I can in 3D arrays.");
// Console.Write("Tell me the size in 1st dimension: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Tell me the size in 2nd dimension: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Tell me the size in 3d dimension: ");
// int L = Convert.ToInt32(Console.ReadLine());
// if (!dimensionValid(N, M, L)){
//     Console.WriteLine("Hey there is " + N*M*L + " elements in array.");
//     Console.WriteLine("But only 100 unique 2-digit numbers. Try again.");
//     System.Environment.Exit(-1);
// }
// int[,,] array = create3DIntUniqueArray(N, M, L, 10, 99);
// Console.WriteLine("Create array is: ");
// print3Darray(array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] createSnail2D(int N, int M){
    SortedDictionary<int, string> directions = new SortedDictionary<int, string>();
    directions.Add(1, "right");
    directions.Add(2, "down");
    directions.Add(3, "left");
    directions.Add(4, "up");
    int[,] result = new int[N,M];
    int cur_direction = 0;
    int counter = 1;
    int i = 0;
    int j = 0;
    State position = new State(i, j, cur_direction);
    while (counter <= N*M){
        bool change_direction = false;
        if (result[position.row,position.col] == 0){
            result[position.row,position.col] = counter;
            counter++;
            // go to the next
            position.goNext();
            //need change direction?
            change_direction = change_direction || (position.getCol() < 0) || (position.getRow() < 0);
            change_direction = change_direction || (position.getCol() >= M);
            change_direction = change_direction || (position.getRow() >= N);
            if (!change_direction){
                change_direction = change_direction || (result[position.row,position.col] != 0);
            }
            if (change_direction){
                position.goPrev();
                position.changeDriection();
                position.goNext();
            }
        } else {
            Console.WriteLine("I'm not on zero! wtf");
        }
        
    }
    return result;
}

void printSnail2D(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j].ToString("D2") + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Hey! I can to snail the 2D matrix");
Console.Write("Tell me the size in 1st dimension: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Tell me the size in 2nd dimension: ");
int M = Convert.ToInt32(Console.ReadLine());
printSnail2D(createSnail2D(N,M));

public struct State{
    public int row;
    public int col;
    private int cur_dir;
    public State(int i, int j, int dir){
        row = i;
        col = j;
        cur_dir = dir;
    }
    public int getRow(){
        return row;
    }
    public int getCol(){
        return col;
    }
    public void goNext(){
        switch (cur_dir)
        {
            case 0:
                col++;
                break;
            case 1:
                row++;
                break;
            case 2:
                col--;
                break;
            case 3:
                row--;
                break;
        }
    }
    public void goPrev(){
    switch (cur_dir)
    {
        case 0:
            col--;
            break;
        case 1:
            row--;
            break;
        case 2:
            col++;
            break;
        case 3:
            row++;
            break;
    }

    }
    public void changeDriection(){
        cur_dir = (cur_dir + 1) % 4;
    }
}
