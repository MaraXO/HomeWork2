
// Task 1

Console.WriteLine("Enter 4 numbers from 0 to 9 !!!");
Console.Write("Digit 1: ");
int digit1 = Convert.ToByte(Console.ReadLine());
Console.Write("Digit 2: ");
int digit2 = Convert.ToByte(Console.ReadLine());
Console.Write("Digit 3: ");
int digit3 = Convert.ToByte(Console.ReadLine());
Console.Write("Digit 4: ");
int digit4 = Convert.ToByte(Console.ReadLine());
int result = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

Console.WriteLine($"Number: {result}");



//Task 2 

Console.WriteLine("Enter 6-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number / 100000;
int num2 = number / 10000 % 10;
int num3 = number / 1000 % 10;
int num4 = number % 1000 / 100;
int num5 = number % 100 / 10;
int num6 = number % 10;
int result = num6 * 100000 + num5 * 10000 + num4 * 1000 + num3 * 100 + num2 * 10 + num1;

Console.WriteLine($"Result: \n{result}");



