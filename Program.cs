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