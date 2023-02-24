// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] arrayMaker(int size, int mina, int maxa){
//     Random rnd = new Random();
//     int[] output = new int[size];
//     for (int i = 0; i < size; i++){
//         output[i] = rnd.Next(mina, maxa);
//     }
//     return output;
// }

// void arrayPrinter(int[] array){
//     if (array.Length == 0){
//         Console.WriteLine("Your array is empty!");
//         return;
//     }
//     Console.Write($"Here is your array: [{array[0]}");
//     for (int i = 1; i < array.Length; i++){
//         Console.Write($", {array[i]}");
//     }
//     Console.Write("].");
// }

// int countEvens(int[] input){
//     int answer = 0;
//     for (int i = 0; i < input.Length; i++){
//         if (input[i] % 2 == 0) answer++;
//     }
//     return answer;
// }

// bool isInputCorrect(int N){
//     if (N > 0) return true;
//     return false;
// }

// Console.WriteLine("I can count even numbers.");
// Console.Write("Give me the number of elements in array: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (!isInputCorrect(N)){
//     Console.WriteLine("Imaginary arrays are all in another sepcialization.");
//     return;
// }
// int[] array = arrayMaker(N, 100, 1000);
// arrayPrinter(array);
// Console.WriteLine($" And the number of evens there is {countEvens(array)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] arrayMaker(int size, int mina, int maxa){
//     Random rnd = new Random();
//     int[] output = new int[size];
//     for (int i = 0; i < size; i++){
//         output[i] = rnd.Next(mina, maxa);
//     }
//     return output;
// }

// void arrayPrinter(int[] array){
//     if (array.Length == 0){
//         Console.WriteLine("Your array is empty!");
//         return;
//     }
//     Console.Write($"Here is your array: [{array[0]}");
//     for (int i = 1; i < array.Length; i++){
//         Console.Write($", {array[i]}");
//     }
//     Console.Write("].");
// }

// int countOddPositions(int[] input){
//     int answer = 0;
//     for (int i = 1; i < input.Length; i = i + 2){
//         answer += input[i];
//     }
//     return answer;
// }

// bool isInputCorrect(int N){
//     if (N > 1) return true;
//     return false;
// }

// Console.WriteLine("I can sum odd positions.");
// Console.Write("Give me the number of elements in array: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (!isInputCorrect(N)){
//     Console.WriteLine("Imaginary arrays are all in another sepcialization.");
//     return;
// }
// int[] array = arrayMaker(N, -100, 100);
// arrayPrinter(array);
// Console.WriteLine($" And the sum of odd positions is: {countOddPositions(array)}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] arrayMaker(int size, double mina, double maxa){
    Random rnd = new Random();
    double[] output = new double[size];
    for (int i = 0; i < size; i++){
        output[i] = Convert.ToDouble(rnd.Next(
            Convert.ToInt32(mina*100), Convert.ToInt32(maxa*100)
            ))/100;
    }
    return output;
}

void arrayPrinter(double[] array){
    if (array.Length == 0){
        Console.WriteLine("Your array is empty!");
        return;
    }
    Console.Write($"Here is your array: [{Math.Round(array[0], 2)}");
    for (int i = 1; i < array.Length; i++){
        Console.Write($", {Math.Round(array[i], 2)}");
    }
    Console.Write("].");
}

double findMaxMinDiff(double[] input){
    double min = input[0];
    double max = input[0];
    for (int i = 1; i < input.Length; i++){
        if (min > input[i]) min = input[i];
        if (max < input[i]) max = input [i];
    }
    return (max - min);
}

bool isInputCorrect(int N){
    if (N > 1) return true;
    return false;
}

Console.WriteLine("I can find the differens between max and min element.");
Console.Write("Give me the number of elements in array: ");
int N = Convert.ToInt32(Console.ReadLine());
if (!isInputCorrect(N)){
    Console.WriteLine("Imaginary arrays are all in another sepcialization.");
    return;
}
double[] array = arrayMaker(N, -10, 10);
arrayPrinter(array);
Console.WriteLine($" And the (MAX - MIN) is: {Math.Round(findMaxMinDiff(array), 2)}");