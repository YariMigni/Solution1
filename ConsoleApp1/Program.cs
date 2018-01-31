using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max(int a[], int dim)

            {
                int max = NULL;
                int i;
                for (i = 0; i < dim; i++)
                {
                    if (max < a[i])
                    {
                        max = a[i];
                    }


                }

                return max;
            }

            //minimo    
            int min(int a[], int dim)
            {
                int i;
                int min;
                for (i = 0; i < dim; i++)
                {
                    if (min > a[i])
                    {
                        min = a[i];
                    }




                }
                return min;
            }


            //main program per verificare le funzioni
            int main()

            {
                int massimo, minimo;
                int a[10] = { 10, 11, 13, 14, 17, 9, 7, 1, 4, 99 };

                massimo = max(a, 10);
                minimo = min(a, 10);

                printf("\nIl massimo dell'array e %d\n", massimo);
                printf("Il minimo dell'array e %d\n\n", minimo);


                return 0;
            }
        }
    }
}
