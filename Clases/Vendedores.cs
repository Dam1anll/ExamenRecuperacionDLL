using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuperacionDLL.Clases
{
    public class Vendedores
    {
       public void CalcularGanacia() 
        {
            int[,] tabla =
            {{500, 3000, 100, 400},
            {1000, 150, 200, 500},
            {250, 1800, 2900, 300},
            {400, 130, 90, 2400},
            {60, 20, 4000, 3600}};

            for(int x= 0; x < tabla.GetLength(0); x++) 
            {
                for(int y = 0; y < tabla.GetLength(1); y++) 
                {
                    Console.WriteLine(tabla[x,y]);
                }
                Console.WriteLine("\t");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Ganacias por Vendedor: ");
            Console.WriteLine($"El Vendedor 1 tuvo una ganacia de: {tabla[0,0] + tabla[1,0] + tabla[2,0] + tabla[3,0] + tabla[4,0]} pesos");
            Console.WriteLine($"El Vendedor 2 tuvo una ganacia de: {tabla[0, 1] + tabla[1, 1] + tabla[2, 1] + tabla[3, 1] + tabla[4, 1]} pesos");
            Console.WriteLine($"El Vendedor 3 tuvo una ganacia de: {tabla[0, 2] + tabla[1, 2] + tabla[2, 2] + tabla[3, 2] + tabla[4, 2]} pesos");
            Console.WriteLine($"El Vendedor 4 tuvo una ganacia de: {tabla[0, 3] + tabla[1, 3] + tabla[2, 3] + tabla[3, 3] + tabla[4, 3]} pesos");

            Console.WriteLine("------------------------------");
            Console.WriteLine("Ganacias por Producto:");
            Console.WriteLine($"Producto 1 genero: { tabla[0,0] + tabla[0,1] + tabla[0,2] + tabla[0, 3]} pesos de ganancia.");
            Console.WriteLine($"Producto 2 genero: {tabla[1, 0] + tabla[1, 1] + tabla[1, 2] + tabla[1, 3]} pesos de ganancia.");
            Console.WriteLine($"Producto 3 genero: {tabla[2, 0] + tabla[2, 1] + tabla[2, 2] + tabla[2, 3]} pesos de ganancia.");
            Console.WriteLine($"Producto 4 genero: {tabla[3, 0] + tabla[3, 1] + tabla[3, 2] + tabla[3, 3]} pesos de ganancia.");
            Console.WriteLine($"Producto 5 genero: {tabla[4, 0] + tabla[4, 1] + tabla[4, 2] + tabla[4, 3]} pesos de ganancia.");
        }
        
    }
}
