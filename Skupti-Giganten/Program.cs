using System;
using System.Data.SqlClient;

namespace Skupti_Giganten
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Admin.Valg1);
            Admin.FørsteMeny(Console.ReadLine());
            




            // Firma.Message();
            //   Console.WriteLine(Firma.Besked);


            Console.ReadLine();
        }



    }

}

