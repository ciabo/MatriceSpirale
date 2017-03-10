using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriceSpirale
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[,] mat = new int[n,n];
            int mul = n * n;
            for (int k = 0; k < n; k++)
            {
                for (int s = 0; s < n; s++)
                {
                    mat[k, s] = 0;
                }
            }
            int counter = 1;
            int i = 0;
            int j = 0;
            int top = n / 2 ;
            for (int p = 0; p < top+1; p++)
            {
                while (j < n && mat[i, j] == 0)
                {
                    mat[i, j] = counter;
                    counter++;
                    j++;
                }
                j--;
                i++;
                while (i < n && mat[i, j] == 0)
                {
                    mat[i, j] = counter;
                    counter++;
                    i++;
                }

                i--;
                j--;
                while (j >= 0 && mat[i, j] == 0)
                {
                    mat[i, j] = counter;
                    counter++;
                    j--;
                }

                i--;
                j++;
                while (i >= 0 && mat[i, j] == 0)
                {
                    mat[i, j] = counter;
                    counter++;
                    i--;
                }
                i++;
                j++;
               
            }
            for (int righe = 0; righe < n; righe++)
            {
                for (int colonne = 0; colonne < n; colonne++)
                {
                    Console.Write(mat[righe, colonne]);
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            i = (n / 2) ;
            j = (n / 2) ;
            int t= 0;
            int f = 0;
            for (int x = 0; x < top +1 ; x++)
            {
                
                while(t<=f)
                {
                    Console.Write(mat[i, j]);
                    Console.Write(" ");
                    i--;
                    t++;
                }
                t = 0;
                if (x == top)
                    break;
                while(t<=f)
                {
                    Console.Write(mat[i, j]);
                    Console.Write(" ");
                    j--;
                    t++;
                }
                f++;
                t = 0;
                while(t<=f)
                {
                    Console.Write(mat[i, j]);
                    Console.Write(" ");
                    i++;
                    t++;
                }
                t = 0;
                while(t<=f)
                {
                    Console.Write(mat[i, j]);
                    Console.Write(" ");
                    j++;
                    t++;
                }
                f++;
                t = 0;
            }
            Console.ReadKey();
        }
    }
}
