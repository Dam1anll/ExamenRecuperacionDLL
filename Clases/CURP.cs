using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuperacionDLL.Clases
{
    public class CURP
    {
        public void Determinar() 
        {
            string[] curpPersona = new string[18];

            Console.WriteLine("Ingrese su CURP, por favor");

            for(int x = 0; x < curpPersona.Length; x++) 
            {
                Console.WriteLine($"Ingrese el caractér: {x + 1}");
                curpPersona[x] = Console.ReadLine();
            }

            if (curpPersona[10] == "H")
            {
                Console.WriteLine("Usted es de sexo Masculino");
            }

            else if (curpPersona[10] == "M")
            {
                Console.WriteLine("Usted es de Sexo Femenino");
            }

            else
            {
                Console.WriteLine("Usted no Existe");
            }

            Console.WriteLine($"Su Fecha de Nacimiento es: {curpPersona[8] + curpPersona[9] + "/" + curpPersona[6] + curpPersona[7] + "/" + curpPersona[4] + curpPersona[5]}");
        }
    }
}
