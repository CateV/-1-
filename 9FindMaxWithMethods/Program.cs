// See https://aka.ms/new-console-template for more information
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] x = { 5, 2, 0, -7, 7, -3, -1, 77, 19 };

int max = Max(Max(x[0], x[1], x[2]), Max(x[3], x[4], x[5]), Max(x[6], x[7], x[8]));

/*int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);*/

// int max = Max(Max(a1, a2, a3), Max(a4, a5, a6), Max(a7, a8, a9));

Console.WriteLine(max);
