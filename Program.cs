//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

/*int a = 7;
int b = 23;
int input = 50; //7, 322

if(input % a == 0 && input % b == 0){
    Console.WriteLine("Да"); 
} else {
    Console.WriteLine("Нет");
}
*/


//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

/*int x = 1;
int y = -1;

if(x > 0 && y > 0){
    Console.WriteLine("1");
}
if(x < 0 && y > 0){
    Console.WriteLine("2");
}
if(x < 0 && y < 0){
    Console.WriteLine("3");
}
if(x > 0 && y < 0){
    Console.WriteLine("4");
}
*/

//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int input = 27;
int first = input / 10;
int second = input % 10;
if(first > second){
    Console.WriteLine($"Max is first {first}");
} else {
    Console.WriteLine($"Max is second {second}");
}
*/

//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую
int input = 568;

/*string digits = input.ToString();
Console.WriteLine(string.Join(", ", digits.ToCharArray()));
*/