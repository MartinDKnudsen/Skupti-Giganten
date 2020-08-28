using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skupti_Giganten
{
   public class Firmaet
    {
        public static int ValgtTal { get; set; }

        public static void Message()
        {

            Console.WriteLine("Welkommen til Skupti-Giganten \n - Din fortrukne El-Handel \n Hvad kunne du tænke dig at gøre nu?");

            Console.WriteLine("1 - Tilføj vare til min kurv \n 2. Se min indkøbskurv \n 3. Bestil varene i min indkøbskurv \n 4. Se status på min bestilling  ");
            string ValgtTal = Console.ReadLine();
           

        }
    }
}
