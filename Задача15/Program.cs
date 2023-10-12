// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
int[] theWeek = { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine($"Введите цифру, обозначающую день недели [0,6]: ");
int number = int.Parse(System.Console.ReadLine());
if (theWeek[number] == 6 || theWeek[number] == 7){
    Console.WriteLine($"Сегодня выходной день!");
}
else{
    Console.WriteLine($"Сегодня будний день!");
}