using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : ContactDetail
    {
        public decimal Salary { get; set; }

        void DialPhone()
        {
            PhoneNumber = "+92-322-2269607";
        }
    }
}
