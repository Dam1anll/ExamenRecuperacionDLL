using ExamenRecuperacionDLL.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuperacionDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vendedores vendedores = new Vendedores();
            //vendedores.CalcularGanacia();

            //CURP curp = new CURP();
            //curp.Determinar();

            Calificaciones calificaciones= new Calificaciones();
            calificaciones.ObtenerCalificacion();

            Console.ReadKey();

        }
    }
}
