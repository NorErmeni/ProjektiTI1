using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektiTI1
{
    class Termini
    {
        public int Id { get; set; }
        public Pacienti Pacient { get; set; }
        public Doktori Doktor { get; set; }
       
        public DateTime Kohaeterminit { get; set; }

        public override string ToString()
        {
            return "TerminId: " + Id + "\nPacient id: " + Pacient.Id + "\nDoktori id: " + Doktor.Id + "\nkoha e terminit: " + Kohaeterminit + "\nsherbimi id: " + Sherbimi.SherbimiId;
        }
    }
}
