// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void printNumbers(int K){
//     if (K != 1){
//         Console.Write(K.ToString() + ", ");
//     } else {
//         Console.WriteLine(K.ToString());
//     }
//     if (K > 1) printNumbers(K - 1);
// }

// Console.WriteLine("I can show you numbers.");
// Console.Write("Give me N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// printNumbers(N);

// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int getNaturalSum(int start, int stop){
//     if (start == stop){
//         return stop;
//     }
//     return start + getNaturalSum(start+1, stop);
// }

// Console.WriteLine("I can sum elems.");
// Console.Write("Give me N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Give me M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your sum is: " + getNaturalSum(Math.Min(M, N), Math.Max(M,N)));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n){
    if (m == 0){
        return n + 1;
    }
    if (n == 0){
        return Ackermann(m - 1, 1);
    }
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine("I can to Ackermann.");
Console.Write("Give me m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Give me n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ackermann func is: " + Ackermann(m, n));
