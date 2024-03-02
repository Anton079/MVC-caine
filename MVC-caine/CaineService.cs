using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_caine
{
    public class CaineService
    {
        public List<Caine> CaineList = new List<Caine>();
        public void LoadData()
        {
            Caine caine1 = new Caine();
            caine1.varsta = 6;
            caine1.inaltime = 10;
            caine1.rasa = "Bulldog Englez";

            Caine caine2 = new Caine();
            caine2.varsta = 5;
            caine2.inaltime = 4;
            caine2.rasa = "Labrador Retriever";

            Caine caine3 = new Caine();
            caine3.varsta = 3;
            caine3.inaltime = 10;
            caine3.rasa = "Beagle";

            Caine caine4 = new Caine();
            caine4.varsta = 7;
            caine4.inaltime = 17;
            caine4.rasa = "Pudel";

            Caine caine5 = new Caine();
            caine5.varsta = 9;
            caine5.inaltime = 165;
            caine5.rasa = "Husky Siberian";

            this.CaineList.Add(caine1);
            this.CaineList.Add(caine2);
            this.CaineList.Add(caine3);
            this.CaineList.Add(caine4);
            this.CaineList.Add(caine5);
        }

        public void AfisareCaini()
        {
            foreach(Caine x in CaineList)
            {
                Console.WriteLine(x.CaineInfo());
            }
        }

        //CRUD
        public bool EditDogHeight(string rasa, int newHeight)
        {
            foreach (Caine x in CaineList)
            {
                if (x.rasa == rasa)
                {
                    x.inaltime = newHeight; 
                    return true;
                }
            }
            return false; 
        }
    }
}
