using System;

namespace VS_code
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            Random a = new Random();
            int max = 0;
            
           int [] b = new int [N];
           for(int i=0; i<N; i++)
           {
                b[i]= a.Next(-10,10);
             Console.WriteLine(b[i]); 
           }

            max = b[0];
            for(int i =0; i<N; i++)
            {
                
                if(b[i]>max)
                {
                    max=b[i];
                }
            }
         Console.WriteLine(max);
          
            Console.ReadKey();

        }
    }
}