using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektiTI1
{
    public class Personi
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LasTname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return FirstName + "\n " + Id + "\n " + LasTname + "\n " + Age + "\n " + Address + "\n " + PhoneNumber;
        }
    }
}
