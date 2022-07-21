Console.WriteLine("Write a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] A = new int [num];

for (int i = 1; 1<=num; i++)
{
    A[i-1] = i*i;
    Console.WriteLine(A[i-1]);
}