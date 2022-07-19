Console.WriteLine ("Введите number: ");
int number = new Random(). Next(9,100);
Console.WriteLine(number);
int x = number/10;
int y = number%10;
if(x>y)
{
 Console.WriteLine(x);
}
else
{
    Console.WriteLine(y);
}