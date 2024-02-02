// int number = 453; 
// int firstDigit = number / 100;
// int thirdDigit = number % 10; 
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"В числе {number} => {result}");


int number = 947;
int thirdDigit = number % 10;
int secondDigit = number / 10 % 10; 
int result = (int)Math.Pow(secondDigit, thirdDigit);
Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");