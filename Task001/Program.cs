int a = 5, b = 7;

int max = 7;
int min = 0;

if (a>max) max=a;
if (b>max) max=b;

Console.WriteLine("max =");
Console.WriteLine(max);

if (a<max) min= a;
if (b<max) min= b;

Console.WriteLine("min =");
Console.WriteLine(min);
