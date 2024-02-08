using System;
namespace Demo
{
class Array
{
static int n=0;
static int m=0;
public static void main()
{
    int[] a = { 1, 2, 3, 4, 5 };
    int[] b = { 3, 7, 1, 4, 6 };
    int[] c = new int[a.Length + b.Length];
    Compare(a,b,c);
    Compare(b,a,c);
    int[] d = new int[m];
    Array.Copy(c, 0, d, 0, m);
    foreach (int i in d) Console.WriteLine(i);
 
    Console.ReadKey();
}
public static void Compare(int[] a,int[] b, int[] c)
{
    

    for (int i = 0; i < a.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < a.Length; j++)
        {
            if (a[i] ==b[j]) count++;
        }
        if (count == 0)
        {
            c[n++] = a[i];
            m++;
        }
    }
}
}
}
