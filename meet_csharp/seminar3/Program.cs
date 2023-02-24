// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// bool isPalindrome(long N){
//     long lhs = N % 100;
//     long rhs = N / 1000;
//     if (lhs % 10 == rhs / 10 && lhs / 10 == rhs % 10) return true;
//     return false;
// }

// bool inputCorrect(long N){
//     if (N > 9999 && N < 100000) return true;
//     return false;
// }

// Console.WriteLine("Palindrome detector");
// Console.Write("Give me a 5-digit number: ");
// long num = Convert.ToInt64(Console.ReadLine());
// if (!inputCorrect(num)) {
//     Console.WriteLine("5-digit number is not detected! Try again.");
//     return -1;
// }
// Console.WriteLine(isPalindrome(num) ? "This is palindrome" : "NO");
// return 0;


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double euqlidDist(double lhs_x, double lhs_y, double lhs_z,
//                   double rhs_x, double rhs_y, double rhs_z){
//     return Math.Sqrt(Math.Pow(lhs_x - rhs_x, 2) +
//                      Math.Pow(lhs_y - rhs_y, 2) +
//                      Math.Pow(lhs_z - rhs_z, 2)
//                      );
// }

// Console.WriteLine("I can do the distance");
// Console.WriteLine("Lets specify the coords");
// Console.Write("Give me the X of dot 1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Give me the Y of dot 1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Give me the Z of dot 1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Give me the X of dot 2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Give me the Y of dot 2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Give me the Z of dot 2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"The distance eq: {Math.Round(euqlidDist(x1, y1, z1, x2, y2, z2), 2)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("I can print the table of cubes");
Console.Write("Give the number: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1) {
    Console.WriteLine("Give me the positive number, please. Try again.");
    return -1;
}
Console.Write("The cubes are: 1");
for (int i = 2; i <= N; i++){
    Console.Write($", {i*i*i}");
}
Console.Write(".");
return 0;