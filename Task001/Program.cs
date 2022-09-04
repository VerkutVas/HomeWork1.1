int a = -9, b = -3;

int max = -9;
int min = 0;

if (a>max) max=a;
if (b>max) max=b;

Console.WriteLine("max =");
Console.WriteLine(max);

if (a<max) min= a;
if (b<max) min= b;

Console.WriteLine("min =");
Console.WriteLine(min);
