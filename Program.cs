// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Ввидите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number < 6)
{
    Console.Write("Будний день");
}
if (number > 5 & number < 8)
{
    Console.Write("Выходгой день");
}
if (number > 7)
{
    Console.Write("В неделе семь дней");
}