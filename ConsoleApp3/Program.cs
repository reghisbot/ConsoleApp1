using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        double resultado = 0;
        
        static void Main(string[] args)
        {
            List<Caja> cajas = new List<Caja>();
            Caja caja = new Caja();
            Console.WriteLine("Ingreso de Cajas al Vagon");
            double limiteVagon1 = 141;

            Console.WriteLine("Ingrese Largo Caja -->");
            caja.Largo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Ancho Caja -->");
            caja.Ancho = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Alto Caja -->");
            caja.Alto = double.Parse(Console.ReadLine());
            var resultado = caja.Largo * caja.Ancho * caja.Alto;
            Console.WriteLine("resultado {0}", resultado);
            Console.ReadKey();

            if (resultado<limiteVagon1)
            {
                cajas.Add(caja);
            }
            else
            {
                Console.WriteLine("Excede el limite del Vagon1!!!");
            }
        }
    }
}
