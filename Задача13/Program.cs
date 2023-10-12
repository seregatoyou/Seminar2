//  Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
//void theSecondNumber(){ 
    Console.WriteLine($"Наше число: ");
    int number = int.Parse(System.Console.ReadLine());
    if (number / 100 != 0){
        while(number >= 1000){
            number = number / 10;
        }
        int a = number % 10;
        Console.WriteLine($"Третья цифра заданного числа: {a}");
    }
    else{
        Console.WriteLine("Третьей цифры не существует.");
    }