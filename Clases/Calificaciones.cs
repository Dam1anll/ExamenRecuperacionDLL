using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuperacionDLL.Clases
{
    public class Calificaciones
    {
        public void ObtenerCalificacion() 
        {
            int[] calificacion = new int[10];
            Random random= new Random();

            Console.WriteLine("------------------------");
            Console.WriteLine("Lista Desordenada");
           
            for(int x = 0; x < calificacion.Length; x++) 
            {
                calificacion[x] = random.Next(100);
                Console.WriteLine(calificacion[x] );
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Lista Ordenada");

            int menor = 0;
            int pos = 0;
            int temp = 0;

            for(int x = 0; x < calificacion.Length - 1; x++) 
            {
                menor = calificacion[x];
                pos = x;

                for(int y = x + 1; y<calificacion.Length; y++) 
                {
                    if (calificacion[y]<menor) 
                    {
                        menor = calificacion[y];
                        pos = y;
                    }
                }

                if(pos != x) 
                {
                    temp = calificacion[x];
                    calificacion[x] =calificacion[pos];
                    calificacion[pos]= temp;
                }
            }

            for(int j = 0; j <calificacion.Length; j++) 
            {
                Console.WriteLine(calificacion[j]);
            }
            
            



        }
    }
}
