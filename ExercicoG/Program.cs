using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoG
{
    class Program
    {
       static int pesquisaBinaria( int [] vetor,int tl, int chave)
        {
            int meio;
            int min = 0;
            int max = tl - 1;
            int p = -1;
            do
            {
                meio = (int)(min + max) / 2;
                if (vetor[meio] == chave)
                {
                    //Retorna  a posição  do numero  na sequencia
                    p= meio;
                    break;
                }
                else if (chave > vetor[meio])
                    min = meio + 1;
                else
                    max = meio - 1;
            } while (min <= max);
            return p;
        }
        static void Main(string[] args)
        {
            int[] a = new int[20];
            int[] b = new int[20];
            int i = 0;
            int j = 0;
            int tl = 20;
            int pos = 0;
            int x;
            int valor;
            Console.WriteLine("Digite um matriz con 20 numeros:");
            for (i = 0; i < tl; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                b[i] = a[i] + 2;
            }
            for (i = 0; i < tl; i++)
            {
                for (j = i + 1; j < tl; j++)
                {
                    if (b[i] > b[j])
                    {
                        x = b[i];
                        b[i] = b[j];
                        b[j] = x;
                    }
                }
            }
            Console.WriteLine("Esse são os valores que temos para pesquisar:");
            for (i = 0; i < tl; i++)
            {
                Console.Write(b[i]);
                Console.WriteLine();
            }
            Console.WriteLine("Digite um valor que voce deseja pesquisar?");
            Console.WriteLine(valor = int.Parse(Console.ReadLine()));
            pos = pesquisaBinaria(b, tl, valor);
            if (pos == -1)
            {
                Console.WriteLine("Valor não encontrado");
            }
            else
            {
                Console.WriteLine("Valor encontrado na posicao:" + pos);
            }
            Console.ReadKey();
        }
    }
}
