// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
int Max(int arg1, int arg2, int arg3);
{
    int result = arg1;
    if (arg2>arg1) result = arg2;
    if (arg3>arg2) result = arg3;
    return result;
}

/* int a1 = 5;
int a2 = 15;
int a3 = 45;
int a4 = 51;
int a5 = 59;
int a6 = 54;
int a7 = 25;
int a8 = 55;
int a9 = 95; */

int[] array {15,45,51,59,54,25,55,95};
array[0] = 12;
Console.WriteLine(array[0]);

/* int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3); */

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);