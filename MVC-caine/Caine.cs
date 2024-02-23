using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_caine
{
    public class Caine
    {
        public int varsta;
        public int inaltime;
        public string rasa;

        public string CaineInfo()
        {
            string text = " ";
            text += "Varsta: " + varsta + "\n";
            text += "Inaltime: " + inaltime + "\n";
            text += "Rasa: " + rasa + "\n";
            return text;
        }
    }
}
