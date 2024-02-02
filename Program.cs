// // // int number = 453; 
// // // int firstDigit = number / 100;
// // // int thirdDigit = number % 10; 
// // // int result = firstDigit * 10 + thirdDigit;
// // // Console.WriteLine($"В числе {number} => {result}");


// // int number = 947;
// // int thirdDigit = number % 10;
// // int secondDigit = number / 10 % 10; 
// // int result = (int)Math.Pow(secondDigit, thirdDigit);
// // Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");


// int number = 925254236; 
// if (number >= 100)
// {
// int thirdDigitFromEnd = number / 100 % 10; 
// Console.WriteLine($"Третья цифра от {number} с конца: {thirdDigitFromEnd}"); 
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }


int a = 6;
int b = 2; 
if (a % b == 0)
{
    Console.WriteLine($"{a} кратно {b}");
}
else
{
    Console.WriteLine($"Остаток от {a} / {b} = {a % b}");
}