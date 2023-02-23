// Homework1 for practice #1

// Task#2. Make a program that takes 2 numbers as input 
// and gives the imformation about what number is greater and which one is less as output

// Console.WriteLine("I can compare numbers");
// Console.Write("Give me the first one: ");
// int lhs = Convert.ToInt32(Console.ReadLine());
// Console.Write("Give me the second one: ");
// int rhs = Convert.ToInt32(Console.ReadLine());
// int less = lhs > rhs ? rhs : lhs;
// int greater = lhs > rhs ? lhs : rhs;
// Console.WriteLine(String.Format("The answer is that {0} is greater then {1}", greater, less));

// Task#4. Make a program that takes 3 numbers as input and gives the
// the maximum among them as output

// Console.WriteLine("I can choose a max among 3!");
// Console.Write("Give me the first one: ");
// int lhs = Convert.ToInt32(Console.ReadLine());
// Console.Write("Give me the second one: ");
// int mhs = Convert.ToInt32(Console.ReadLine());
// Console.Write("Give me the third one: ");
// int rhs = Convert.ToInt32(Console.ReadLine());
// int max = lhs > mhs ? (lhs > rhs ? lhs : rhs) : (mhs > rhs ? mhs : rhs);
// Console.WriteLine(String.Format("The truth is that the maximum of given is: {0}", max));

// Task#6. Make a programm that takes single number as input and gives 
// the answer odd it or not as output

// Console.WriteLine("I can detect even numbers!");
// Console.Write("Give me a number: ");
// int inp = Convert.ToInt32(Console.ReadLine());
// string answer = inp % 2 == 0 ? "Yes!" : "No!";
// Console.WriteLine("The answer is " + answer);

// Task#8. Make a program that takes a single number N as input and gives
// a row of all even numbers from 1 to N including borders as output

Console.WriteLine("I can show you positive even numbers!");
Console.Write("Give the N number: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 2)
    Console.WriteLine("There is NO positive even numbers less then " + N);
else
{
    int i = 2;
    Console.Write("The even numbers below (or eq.) N are: 2");
    i = i + 2;
    while (i <= N){
        Console.Write(", " + i);
        i = i + 2;
    }
}