using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    internal class registrationClass
    {
        public string rname;
        public string remail;
        public string rcity;
        public string rpassword;
        public registrationClass(string rname, string remail, string rcity, string rpassword)
        {
            this.rname = rname;
            this.remail = remail;
            this.rcity = rcity;
            this.rpassword = rpassword;
        }
    }
}
