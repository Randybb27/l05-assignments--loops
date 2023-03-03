// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Enter a number");
int num1 = 0;

try
{
    num1 = int.Parse(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Please enter a valid number");
    return;
}

Console.WriteLine("Enter another number");
int num2 = 0;

try
{
    num2 = int.Parse(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Please enter a valid number");
    return;
}
var option = "0";
while(option != "5"){
Console.WriteLine(@"Enter your option
1. Add
2. Multiply
3. Odd or Even
4. Display Range
5. Exit 
");

option = Console.ReadLine();


switch (option)
{
    case "1":
        AddNumbers(num1, num2);
        break; 
    case "2":
        multiplyNumbers(num1, num2);
        break;
    case "3":
        oddOrEven(num1, num2);
        break;
    case "4":
        displayRange(num1 , num2);
        break;
    default:
        Exit(num1, num2);
        break;
}
}

static void AddNumbers (int num1 , int num2) {
    var sum = num1 + num2;
    Console.WriteLine($"The sum is : {sum}") ;
}

void multiplyNumbers(int num1, int num2) {
    var sum = num1 * num2;
    Console.WriteLine($"The sum is : {sum}");
}

void oddOrEven (int num1 , int num2){
var result1 = num1 % 2 == 0 ? "even" : "odd";
var result2 = num2 % 2 == 0 ? "even" : "odd";

    Console.WriteLine($"The first number is {result1} and the second number is {result2}");
}
void displayRange (int num1 , int num2) {
while(num1 <= num2) {
    Console.Write(num1);
    num1 = num1 + 1;
    int target = num2;
}}

 void Exit (int num1 , int num2){
     Console.WriteLine("Exit the program");
 }


//  static void displayRange (int num1 , int num2); {
//     int num1 = num1 + 1;
//     int target = num1 + 5;
//     Console.Writeline($"{num1} < {target}");
// }