using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektiTI1
{
    class Vizita
    {
        public string Anamneza { get; set; }
        public string Diagnoza { get; set; }
        public string Egzaminimet { get; set; }
        public string Terapia { get; set; }
        public Termini Termini { get; set; }


        public override string ToString()
        {
            return "Anamneza: " + Anamneza + "\nDiagnoza: " + Diagnoza + "\nEgzaminimet: " + Egzaminimet + "\nTerapia: " + Terapia +
                 "\nTermini: " + Termini.Id;
        }
    }
}
