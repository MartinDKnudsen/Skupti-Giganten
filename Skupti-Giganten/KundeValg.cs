using System;

namespace Skupti_Giganten
{
    public class KundeValg
    {

        public static string Besked = ("Welkommen til Skupti-Giganten \n - Din fortrukne El-Handel \n __________________________________________ \n  Hvad kunne du tænke dig at gøre nu?");
        public static string ValgtTal = ("1. Se udvalg \n 2. Se min indkøbskurv \n 3. Gå til betaling \n 4. Se status på min bestilling");
        public static int Tal;

        public static void Message()
        {

            Console.Clear();
            Console.WriteLine($"{Besked} \n {ValgtTal}");
           


            
           //Besked = ("Welkommen til Skupti-Giganten \n - Din fortrukne El-Handel \n __________________________________________ \n  Hvad kunne du tænke dig at gøre nu?");

         //  ValgtTal = ("1 Tilføj vare til min kurv \n 2. Se min indkøbskurv \n 3. Bestil varene i min indkøbskurv \n 4. Se status på min bestilling  ");

        //    Tal = Convert.ToInt32(Console.ReadLine());


        }
    }




}


