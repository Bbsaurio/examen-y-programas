using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_y_programas
{
     class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("inserte la calificacion del examen");
            double CE= double.Parse(Console.ReadLine());
            System.Console.WriteLine("inserte los programas entregados");
            double PE=double.Parse(Console.ReadLine());
            if (CE >= 70 && PE>=8) 
            {
                System.Console.WriteLine("aprobado");
            }
            else
            {
                System.Console.WriteLine("reprobado");
            }
            Console.ReadKey();
        }
    }
}
