using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_caine
{
    public class View
    {
        CaineService caineService = new CaineService();

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toti cainii");
            Console.WriteLine("Apsasati tasta 2 ca sa se afiseze toti cainii de o anumita greutate");
            Console.WriteLine("Apasati tasta 3 si introduceti cainele pe care il doriti");
            Console.WriteLine("Apasati tasta 4 pentru adauga un caine nou");
        }

        public void play()
        {
            bool running = true;
            caineService.LoadData();

            while(running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        caineService.AfisareCaini();
                        break;
                }
            }
        }
    }
}
