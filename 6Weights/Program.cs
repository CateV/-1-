// See https://aka.ms/new-console-template for more information
int[] weight = {5,10,7,1,13};
int n = 5;
int i = 0;
int max = weight[i];
while (i<n)
{
  if (weight[i]>max)
  {
   max = weight[i+1];
    }
     i++;
    }

Console.WriteLine(max);

Console.WriteLine("Hello, World!");
