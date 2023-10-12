// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
//void theSecondNumber(){
    int number = new Random().Next(10, 1000);
    Console.WriteLine($"Наше число: {number} ");
    int a = number % 100;
    int b = a / 10;
    Console.WriteLine($"Вторая цифра трехзначного числа: {b}");
//}