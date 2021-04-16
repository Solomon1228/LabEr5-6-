using System;
class Input
    {
        public static int Integer(string msg, int min = Int32.MinValue, int max = Int32.MaxValue)
        {

            bool f; int n;
            n = 0;
            do
            {
                try
                {
                    f = true;
                    Console.Write(msg);
                    string sw = Console.ReadLine();
                    n = Convert.ToInt32(sw);
                    if (n > max || n < min)
                    {
                        f = false;
                        Console.WriteLine("Выход за границу условия... \n ");
                    }
                }
                catch (FormatException)
                {
                    f = false;
                    Console.WriteLine("Неправильный формат ввода... ");
                }
            } while (!f);
            return n;
        }
    }

class MainClass 
{
  public static void Main (string[] args) 
  {
    int a = Input.Integer("Первая часть бинома : ");
    int b = Input.Integer("Вторая часть бинома : ");
    int n = Input.Integer("Степень : ");
    int[,] arr = new int[n + 1,n + 1];

    for(int i = 0;i <= n;i++)
    {
      for(int j =0; j <= n; j++)
      {
        if(i==0 || j == 0)
        {
          arr[i,j] = 1;
        }
        else
        {
          arr[i,j] = arr[i-1,j] + arr[i,j-1];
        }
      }
    }
    
    for(int i = 0;i <= n;i++)
    {
      for(int j =0; j <= n; j++)
      {
        Console.Write($"{arr[i,j],4}");
      }
      Console.WriteLine();
    }

    for(int i = 0; i<=n; i++)
    {
      if(i == 0 && b>=0)
        {
          Console.Write($"{a}^{n}+");  
        }
      else 
      if(i == 0 && b<0)
        {
          Console.Write($"{a}^{n}");
        } 
        else
        if(i==n)
          {
            Console.Write($"{b}^{i}");
          }
          else
          if(b>=0)
            {
            Console.Write($"{arr[n-i,i]}*{a}^{n-i}*{b}^{i}+");
            }
            else
              {
                Console.Write($"{b}^{i}*{arr[n-i,i]}*{a}^{n-i}");
              }
    }
  }
}