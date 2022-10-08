//Задача 10

/*Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine((num / 10) % 10);

//Задача 13
Console.Write("Введите число от 100 до 99999 включительно: ");
int num = int.Parse(Console.ReadLine());
if(num < 100) 
{
Console.WriteLine("Введите число из заданного промежутка!");
}
else
{
    if(num<1000)
    {Console.WriteLine(num % 10);}
    if(num<10000 && num>999)
    {Console.WriteLine(num/10%10);}
    if(num<100000 && num>9999)
    {Console.WriteLine(num/100%10);}
}*/

//Задача 15

Console.Write("Введите цифру, обозначающую день недели: ");
int num = int.Parse(Console.ReadLine());
if (num<1 || num>7)
{Console.WriteLine("В неделе 7 дней!");}
else
{
    if (num==6 || num==7)
    {Console.WriteLine("Сегодня выходной!)");}
    else
    {Console.WriteLine("Сегодня не выходной!(");}
}




