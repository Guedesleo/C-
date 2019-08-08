using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[12];
            int[] b = new int[12];
            int[] c = new int[12];
            int x=0;
            int i;
            int j;
            Console.Write("Digite 12 numeros para Matriz A:\n");
            for (i = 0; i < 12; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 12; i++)
            {
                for (j = i + 1; j < 12; j++)
                {
                    if (a[i] > a[j])
                    {
                        x = a[i];
                        a[i] = a[j];
                        a[j] = x;
                    }
                }
            }
            Console.Write("Digite 12 numeros para Matriz B:\n");
            for (i = 0; i < 12; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 12; i++)
            {
                for (j = i + 1; j < 12; j++)
                {
                    if (b[i] > b[j])
                    {
                        x = b[i];
                        b[i] = b[j];
                        b[j] = x;
                    }
                }
            }
            for (i = 0; i < 12; i++)
            {
                c[i] = a[i] + b[i];
            }
            for (i = 0; i < 12; i++)
            {
                for (j = i + 1; j < 12; j++)
                {
                    if (c[i] < c[j])
                    {
                        x = c[i];
                        c[i] = c[j];
                        c[j] = x;
                    }
                }
            }
            Console.Write("Os valores em ordem decrescente com um soma das duas amtrizes A e B: \n");
                    for(i = 0; i < 12; i++)
                    {
                         Console.Write(c[i]);
                         Console.WriteLine();
                    }
            Console.ReadKey();
        }
    }
}
