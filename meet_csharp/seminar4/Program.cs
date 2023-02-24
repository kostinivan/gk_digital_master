// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// bool isInputCorrect(int p){
//     if (p > 0) return true;
//     return false;
// }

// Console.WriteLine("I can pow!");
// Console.Write("Give me a number: ");
// double num = Convert.ToDouble(Console.ReadLine());
// Console.Write("Give me a power: ");
// int pow = Convert.ToInt32(Console.ReadLine());
// if (!isInputCorrect(pow)) {
//     Console.WriteLine("Power is a positive integer. Try again.");
//     return -1;
// }
// Console.WriteLine($"The answer is: {Math.Pow(num, pow)}");
// return 0;

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int sumOfDigits(int num){
//     int sum = 0;
//     while (num != 0){
//         sum = sum + Math.Abs(num % 10);
//         num /= 10;
//     }
//     return sum;
// }

// Console.WriteLine("I can give a sum of digits.");
// Console.Write("Give me a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The sum of digits of given number is {sumOfDigits(num)}");


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arrayMaker(int size, int mina, int maxa){
    Random rnd = new Random();
    int[] output = new int[size];
    for (int i = 0; i < size; i++){
        output[i] = rnd.Next(mina, maxa);
    }
    return output;
}

void arrayPrinter(int[] array){
    if (array.Length == 0){
        Console.WriteLine("Your array is empty!");
        return;
    }
    Console.Write($"Here is your array: [{array[0]}");
    for (int i = 1; i < array.Length; i++){
        Console.Write($", {array[i]}");
    }
    Console.WriteLine("].");
}

bool isCorrectInput(int N){
    if (N < 0) return false;
    return true;
}

Console.WriteLine("I am the Generator of Arrays.");
Console.Write("Give me the size of your array: ");
int N = Convert.ToInt32(Console.ReadLine());
if (!isCorrectInput(N)) {
    Console.WriteLine("Imaginary arrays are all in other specialization! Try agagin.");
    return;
}
int [] oppa = arrayMaker(N, -100, 100);
arrayPrinter(oppa);