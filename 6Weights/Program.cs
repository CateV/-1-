// See https://aka.ms/new-console-template for more information
int weight = (5,10,7,1,3);
int n = 5;
int i = 0;
int max = weight(i);
while (i<n)
{
  if (weight(i) < weight(i+1))
  {
   max = weight(i+1);
   i++;
  }  
}
Console.WriteLine(max);

Console.WriteLine("Hello, World!");
