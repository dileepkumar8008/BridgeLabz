using System;
namespace Demo1
{
class string
{
public static void main(String[] args)
{
 string a = "shashank";
 char[] b = a.ToCharArray();
 bool[] c=new bool[b.Length];
 for (int i = 0; i < b.Length; i++)
 {
     int count = 1;
     if (c[i] == false)
     {
         for (int j = i + 1; j < b.Length - 1; j++)
         {
             if (b[i] == b[j])
             {
                 count++;
                 c[j] = true;
             }
         }
      Console.WriteLine(b[i] + " Contains " + count + " times");
     }
 }
}
}
}
