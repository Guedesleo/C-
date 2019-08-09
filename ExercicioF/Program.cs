using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioF
{
    class Program
    {
        static int BuscaSequencial(double [] b, int tl, double valor)
        {
            int i = 0;
            int retorno = 0;
            while(i<tl && b[i]!= valor)
            {
                i++;
            }
            if(i>=tl)
            {
                i = -1;
            }
            return i;
        }
        static void Main(string[] args)
        {
            double[] a = new double[30];
            double[] b = new double[30];
            int i=0;
            int tl = 30;
            int pos = 0;
            double valor; 

            Console.WriteLine("Digite um matriz com 30 numeros:");
            for (i = 0; i < tl; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }
           for (i = 0; i < tl; i++)
               {
                    b[i]=a[i]*a[i]*a[i];
               }
            Console.WriteLine("Esse são os valores que temos para pesquisar:");
            for (i = 0; i < tl; i++)
                     {
                        Console.Write(b[i]);
                        Console.WriteLine();
                     }
            Console.WriteLine("Digite um valor que voce deseja pesquisar?");
            Console.WriteLine(valor = double.Parse(Console.ReadLine()));
            pos = BuscaSequencial(b,tl,valor);
            if (pos == -1 )
            {
                Console.WriteLine("Valor não encontrado");
            }
            else
            {
                Console.WriteLine("Valor encontrado na posicao:"+pos);
            }
            Console.ReadKey();
        }
    }
}
