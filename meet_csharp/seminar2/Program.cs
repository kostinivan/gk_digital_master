//Homework for practice#2

// Task#10. make a program that takes 3-digit number as input 
// and gives the second digit of this number as output 

// int second_digit(int input){
//     return (input / 10) % 10;
// }

// Console.WriteLine("I can detect the second digit.");
// Console.Write("give me a 3-digit number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 100){
//     Console.WriteLine("give me 3-digit number!!");
//     System.Environment.Exit(1);
// }
// Console.WriteLine($"The second digit is {second_digit(N)}");

//Task 13. Make a porgram that takes a number as input and gives the 3d digit as output. 
// If there is no 3d digit program should tell about it.
// int third_digit(int N){
//     if (N < 100) return -1;
//     while (N > 999) N = N / 10;
//     return N % 10;
// }
// Console.WriteLine("I can choose 3d digit");
// Console.Write("Give me the number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int answer = third_digit(N);
// if (answer == -1) Console.WriteLine("There is no 3d digit!");
// else Console.WriteLine($"The third ditgit is {answer}");

//Task 15. Make a program that takes a digit that represent the day of week and checks if
// this day is a holiday or not.
bool isHoliday(int a){
    if (a == 6 || a == 7) return true;
    return false;
}

Console.WriteLine("I can detect holidays");
Console.Write("Give me a serial number of a day: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isHoliday(a) ? "This is holiday" : "This is a working day");