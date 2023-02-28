// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Console.WriteLine("I can count positive numbers!");
// Console.Write("Give me please quantity of numbers: ");
// int M = Convert.ToInt32(Console.ReadLine());
// while (M < 1){
//     Console.Write("Make it natural dude. Above zero dude. Try dat out again: ");
//     int M = Convert.ToInt32(Console.ReadLine());
// }
// int counter = 0;
// for (int i = 0; i < M; i++){
//     Console.Write("Give me the next number ("+(M-i)+") left :");
//     int c = Convert.ToInt32(Console.ReadLine());
//     if (c > 0) counter++;
// }
// Console.WriteLine("Amoung numbers there was " + counter + " positive number(s)");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("I can find intersection between 2 lines.\ny = k1 * x + b1,\nand\ny = k2 * x + b2");
Console.WriteLine("Give me the coefs:");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2){
    if (b1 == b2){
        Console.WriteLine("Those two lines coincide == every dot of each line is an intersection");
    } else {
        Console.WriteLine("Those two lines are parallel == no intersection");
    }
} else {
    // k1x + b1 = k2x + b2 => x0 = (b2 - b1) / (k1 - k2). never zero cause k1!=k2
    // then y0 = k1x0 + b1. easy
    double x0 = (b2 - b1)/(k1 - k2);
    double y0 = k1*x0 + b1;
    Console.WriteLine("Intersection has been detected at point (" + Math.Round(x0, 2) + ", " + Math.Round(y0,2) + ").");
}