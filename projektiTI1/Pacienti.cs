using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektiTI1
{
    class Pacienti:Personi
    {
        public string BloodType { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }

        public override string ToString()
        {

            return "id: " + Id + "\nEmri: " + FirstName + "\nMbiemri: " + LasTname + "\nMosha: " + Age + "\nAdresa: " + Address +
                "\nNumri telefonit: " + PhoneNumber + "\nGrupi gjakut: " + BloodType;
        }
    }
}
