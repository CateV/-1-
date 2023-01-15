// See https://aka.ms/new-console-template for more information
int a = 5;
int b = 2;
int c = 4;
int d = 1;
int e = 9;

int max = a;

if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = e;

Console.WriteLine($"значение max = {max}");
