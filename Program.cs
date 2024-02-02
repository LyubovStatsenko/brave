int number = 453; 
int firstDigit = number / 100;
int thirdDigit = number % 10; 
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine($"В числе {number} => {result}");