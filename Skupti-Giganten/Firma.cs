using System;
namespace Skupti_Giganten
{
    public class Firma
    {
        

    }
    public class Admin
    {

        public static string Valg1 = "Er du Kunde eller Admin? \n 1. Kunde \n 2. Admin ";


        public static void FørsteMeny(string A)
        {
        
            if (A == "2")
            {
                VarenePåShoppen.AdminValg();
            }
            else if (A =="1")
            {

                KundeValg.Message();


            }

        }

            
    }
    
}
        

       



