using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : ContactDetail, NationalIdentity
    {
        public int @Class { get; set; }
        public decimal GPA { get; set; }

        #region Method Overloading

        public void CalculateFee()
        {
            Console.WriteLine("Fee of the month is 10000.");
        }

        public void CalculateFee(int month)
        {
            Console.WriteLine($"Fee of the month({month}) is 10000.");
        }

        public void CalculateFee(int month, string year)
        {
            Console.WriteLine($"Fee of the month({month}) is 10000.");
        }

        #endregion

        #region Method Overriding

        public override void LoginFacebook()
        {
            Console.WriteLine("Facebook is logged in from Student class.");
        }

        public void CallRealMethod()
        {
            base.LoginFacebook();
        }

        #endregion
    }
}
