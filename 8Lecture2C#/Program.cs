// See https://aka.ms/new-console-template for more information
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 5;
int a2 = 15;
int a3 = 45;
int a4 = 51;
int a5 = 59;
int a6 = 574;
int a7 = 25;
int a8 = 55;
int a9 = 95;

int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);


Console.WriteLine(max);
