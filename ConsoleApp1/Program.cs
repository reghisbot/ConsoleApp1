using System;

namespace ConsoleApp1
{
    /// <summary>
    /// ejericio 1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            var m = new string[n, n];
            Console.WriteLine("Solucion al Ejercicio 1");
            int nFilas = 0, fila = 0;
            do
            {
                Console.Write("Digite la Dimension de la Matriz:  ");
                nFilas = int.Parse(Console.ReadLine());
                if (nFilas < 1 || nFilas > 10)
                {
                    nFilas = 5;
                }
            } while (nFilas < 1 || nFilas > 10);
            m = new string[nFilas, nFilas];
            for (int f = 0; f < m.GetLength(0); f++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {
                    int r = c % 2;
                    int restof = f % 2;
                    if (restof==0)
                    {
                        if (r == 0)
                        {
                            m[f, c] = "X";
                        }
                        else
                        {
                            m[f, c] = "_";
                        }
                        Console.Write(m[f, c] + " ");
                    }
                    else
                    {
                        if (r == 0)
                        {
                            m[f, c] = "_";
                        }
                        else
                        {
                            m[f, c] = "X";
                        }
                        Console.Write(m[f, c] + " ");
                    }
                    
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
