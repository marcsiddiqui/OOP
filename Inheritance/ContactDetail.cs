using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ContactDetail
    {
        protected string PhoneNumber { get; set; }
        public string WhatsAppNumber { get; set; }
        public string Email { get; set; }
        public string SkypeId { get; set; }
        public string FacebookId { get; set; }
        public string LinkedInId { get; set; }

        public virtual void LoginFacebook()
        {
            Console.WriteLine("Facebook is logged in from ContactDetail class.");
        }
    }


    // Access Modifier
    // public       --> available in whole project from anywhere
    // internal     --> available in whole project from anywhere, but only in the same project not in all
    // private      --> only in the same class, even not in the derived (inheritance)
    // protected    --> allow to use the property or method in the same class also in the derived class (inheritance)
}
