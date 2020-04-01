using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
//Exercise 2.1
            Console.WriteLine("Exercise_2.1");
            int A=Convert.ToInt32(Console.ReadLine());
            int B=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            Console.WriteLine($"All digits between {A} & {B}");
            for(int i=A+1;i<B;i++)
            {
                Console.WriteLine(i);
                sum+=i;
            }
            System.Console.WriteLine("sum="+sum);
            Console.WriteLine($"All odd digits between {A} & {B}");
            for(int i=A+1;i<B;i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
            System.Console.WriteLine();

            //Exercise 3.1  
            Console.WriteLine("Exercise_3.1");      
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    if((j==1 || j==10)||(i==1 || i==5))
                    {
                        System.Console.Write("*");
                    }
                    else 
                    {
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();

            //Exercise 3.2
            Console.WriteLine("Exercise_3.2");
            int m=5;
            for(int i=1;i<=m;i++)
            {
                for(int j=1;j<=m;j++)
                {
                    if((j==1|| i==j || i==m))
                    {
                        System.Console.Write("*");
                    }
                    else 
                    {
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();

            //Exercise 3.3
            Console.WriteLine("Exercise_3.3");
            int h=5;
            for(int i=1;i<=h;i++)
            {
                for(int k=h-1;k>=i;k--)
                {
                    System.Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    if((j==1|| i==j || i==h))
                    {
                        System.Console.Write("* ");
                    }
                    else
                    {
                       System.Console.Write("  ");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
           
           //Exercise 3.4
            Console.WriteLine("Exercise_3.4");
            int m3=7;
            int f=m3/2+1;
            for(int i=1;i<=m3;i++)
            {
                for(int j=1;j<=m3;j++)
                {
                    if((j==f|| j==m3-f+1))
                    {
                        System.Console.Write("*");
                    }
                    else 
                    {
                        System.Console.Write(" ");
                    }
                }
                if(i<=m3/2)
                {
                    f--;
                }
                else
                {
                    f++;
                }
                System.Console.WriteLine();
            }

            //Exercise 4
            Console.WriteLine("Exercise_4");
            double p=Convert.ToDouble(Console.ReadLine());
            double s=1000;
            int q=0;
            while(s<=1100)
            {
                s=s*(p/100+1);
                q++;
            }
            Console.WriteLine("Amount of month="+q
            );
            Console.WriteLine("Total size of contribution="+s);
            

            Console.ReadKey();        }
    }
}
