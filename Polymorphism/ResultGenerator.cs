using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class ResultGenerator : Exam
    {
        #region compile time polymorphism Method overloading

        public void CalculateTotalMarks(int a, int b)
        {
            var result = a + b;
            Console.WriteLine($"Total marks are {result}.");
        }

        public void CalculateTotalMarks(double z, double b)
        {
            var result = z + b;
            Console.WriteLine($"Total marks are {result}.");
        }

        public void CalculateTotalMarks(double a, double b, double c)
        {
            var result = a + b + c;
            Console.WriteLine($"Total marks are {result}.");
        }

        //public void CalculateTotalMarks(double a, double b)
        //{
        //    var result = a + b + c;
        //    Console.WriteLine($"Total marks are {result}.");
        //}

        #endregion

        #region compile time polymorphism Operator Overloading

        public void PlusOperatorDoingSum()
        {
            int x = 7;
            int y = 5;
            int sum = x + y;
            Console.WriteLine(sum);
        }

        public void PlusOperatorDoingConcatenation()
        {
            string firstString = "Harry";
            string secondString = "Styles";

            string concatenatedString = firstString + secondString;
            Console.WriteLine(concatenatedString);
            // Output: HarryStyles
        }

        #endregion

        #region Runtime Polymorphism

        public override void ReCheckCopies()
        {
            Console.WriteLine("We are rechecking copies after result.");
        }

        #endregion
    }

    public class Exam
    {
        public virtual void ReCheckCopies()
        {
            Console.WriteLine("We are rechecking copies before result.");
        }
    }
}
