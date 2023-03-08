using System;

namespace ConsoleApp2
{
    class Program
    {
        static int[] myArray = new int[] { 1, 2, -1, 1, 0, 1, 2, -1, -1, -2 };
        static void Main(string[] args)
        {
            int n = 4;
            var m = new string[4, 4];
            // Carga Val Matriz y la X en pos (1,1)
            for (int f = 0; f < m.GetLength(0); f++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {
                    if (f == 0 && c == 0)
                    {
                        m[f, c] = "X";
                    }
                    else
                    {
                        m[f, c] = "O";
                    }
                    Console.Write(m[f, c] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Ahora Aplicamos la Matrix { 1h, 2v, -1h, 1v, 0h, 1v, 2h, -1v, -1h, -2v }");
            Console.ReadKey();
            for (int myArrayp = 0; myArrayp < myArray.Length; myArrayp++)
            {
                int H_V = myArrayp % 2;
                int content = myArray[myArrayp];
                bool band = true;
                switch (H_V)
                {
                    case 0:
                        Console.WriteLine("--------------------");
                        for (int f = 0; f < m.GetLength(0); f++)
                        {
                            for (int c = 0; c < m.GetLength(1); c++)
                            {
                                if (m[f, c] == "X" && band)
                                {
                                    var col = (c + content) >= 3 ? 3 : (c + content);
                                    m[f, col] = "X";
                                    if (content!=0 && (c + content <= 3))
                                    {
                                        m[f, c] = "O";
                                    }
                                    band = false;
                                }
                                Console.Write(m[f, c] + " ");
                            }
                            Console.WriteLine(" ");
                        }
                        // reimprima verificacion
                        Console.WriteLine("=========H=========");
                        for (int f = 0; f < m.GetLength(0); f++)
                        {
                            for (int c = 0; c < m.GetLength(1); c++)
                            {
                                Console.Write(m[f, c] + " ");
                            }
                            Console.WriteLine(" ");
                        }
                        break;
                    case 1:
                        Console.WriteLine("--------------------");
                        for (int f = 0; f < m.GetLength(0); f++)
                        {
                            for (int c = 0; c < m.GetLength(1); c++)
                            {
                                if (m[f, c] == "X" && band)
                                {
                                    var fila = (f + content) >= 3 ? 3 : (f + content);
                                    m[fila, c] = "X";
                                    if (content != 0 && (f+content<=3))
                                    {
                                        m[f, c] = "O";
                                    }
                                    band = false;
                                }
                                Console.Write(m[f, c] + " ");
                            }
                            Console.WriteLine(" ");
                        }
                        // reimprima verificacion
                        Console.WriteLine("=========V=========");
                        for (int f = 0; f < m.GetLength(0); f++)
                        {
                            for (int c = 0; c < m.GetLength(1); c++)
                            {
                                Console.Write(m[f, c] + " ");
                            }
                            Console.WriteLine(" ");
                        }
                        break;
                    default:
                        break;
                }
                //Console.ReadKey();
            }
            
        }
    }
}
