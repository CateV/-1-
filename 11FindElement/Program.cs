// See https://aka.ms/new-console-template for more information
int[] array = {15,45,51,59,54,25,55,59};
int n = array.Length;
int find = 59;
int index = 0;
while (index < n)
{
   if (array[index] == find) 
   {
    Console.WriteLine(index);
    break;
    }
   
    index++;
}