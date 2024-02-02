// // ДЗ 
// // Задача 1 
// int a = 32; 
// if (a % 7 == 0 && a % 23 == 0)
// {
// Console.WriteLine($"{a} кратно 7 и 23");
// }
// else
// {
// Console.WriteLine($"{a} не кратно 7 и 23");
// }


// // Задача 2 
// int x = -5; 
// int y = 6; 
// if (x > 0 && y > 0)
// {
//     Console.WriteLine($"1 четверть");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine($"2 четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine($"3 четверть");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine($"4 четверть");
// }
// else
// {
//     Console.WriteLine($"Точка находится на оси координат");
// }


// // Задача 3 
// int a = 52; 
// if (a >=10 && a <=99)
// {
//     int firstDigit = a / 10; 
//     int secondDigit = a % 10; 
//     if (firstDigit>secondDigit)
//     {
//         Console.WriteLine($"{firstDigit}");
//     }
//     else 
//     {
//          Console.WriteLine($"{secondDigit}");
//     }
// }
// else 
// {
//     Console.WriteLine("Число не двузначное");
// }


// Задача 4 
int N = 203; 
if (N > 0)
{
    int firstDigitFromEnd = N % 10;
    int secondDigitFromEnd = N / 10 % 10; 
    int thirdDigitFromEnd = N / 100 % 10; 
    int fourDigitFromEnd = N / 1000; 
    if (N >999)
    {
    Console.WriteLine ($"{fourDigitFromEnd}, {thirdDigitFromEnd}, {secondDigitFromEnd}, {firstDigitFromEnd}");
    }
    else if (N >99 && N <1000)
    {
    Console.WriteLine ($"{thirdDigitFromEnd}, {secondDigitFromEnd}, {firstDigitFromEnd}");
    }
     else if (N >9 && N <100)
    {
    Console.WriteLine ($"{secondDigitFromEnd}, {firstDigitFromEnd}");
    }
     else if (N <=9)
    {
    Console.WriteLine ($"{firstDigitFromEnd}");
    }
}
else 
{
    Console.WriteLine("Число не является натуральным");
}







// // // // int number = 453; 
// // // // int firstDigit = number / 100;
// // // // int thirdDigit = number % 10; 
// // // // int result = firstDigit * 10 + thirdDigit;
// // // // Console.WriteLine($"В числе {number} => {result}");


// // // int number = 947;
// // // int thirdDigit = number % 10;
// // // int secondDigit = number / 10 % 10; 
// // // int result = (int)Math.Pow(secondDigit, thirdDigit);
// // // Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");


// // int number = 925254236; 
// // if (number >= 100)
// // {
// // int thirdDigitFromEnd = number / 100 % 10; 
// // Console.WriteLine($"Третья цифра от {number} с конца: {thirdDigitFromEnd}"); 
// // }
// // else
// // {
// //     Console.WriteLine("Третьей цифры нет");
// // }


// int a = 6;
// int b = 2; 
// if (a % b == 0)
// {
//     Console.WriteLine($"{a} кратно {b}");
// }
// else
// {
//     Console.WriteLine($"Остаток от {a} / {b} = {a % b}");
// }


