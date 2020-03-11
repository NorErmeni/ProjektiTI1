using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace projektiTI1
{
    class Doktori:Personi
    {
        public string Pozita { get; set; }

        public string Kualifikimi { get; set; }
      

        public override string ToString()
        {
            return "id: " + Id + "\nEmri: " + FirstName + "\nMbiemri: " + LasTname + "\nMosha: " + Age + "\nAdresa: " +
                Address + "\nNumri telefonit: " + PhoneNumber + "\nPozita: " +
                Pozita + "\nKualifikimi: " + Kualifikimi;

        }
    }
}
