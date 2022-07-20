Console.WriteLine($"Введите X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"P: ({x}; {y})");
if(x>0 && y>0) {Console.WriteLine($"1 четверть");}
if(x<0 && y>0) {Console.WriteLine($"2 четверть");}
if(x<0 && y<0) {Console.WriteLine($"3 четверть");}
if(x>0 && y<0) {Console.WriteLine($"4 четверть");}