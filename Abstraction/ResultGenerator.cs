using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class ResultGenerator : IResultGenerator
    {
        public void AssignMarks()
        {
            var a = 0;
            var b = 5;

            var c = b / a;

            Console.WriteLine("Calling a method AssignMarks.");
        }

        public void CheckCopies()
        {
            Console.WriteLine("Calling a method CheckCopies.");
        }

        public void Corrections()
        {
            Console.WriteLine("Calling a method Corrections.");
        }

        public void PrizeDistribution()
        {
            Console.WriteLine("Calling a method PrizeDistribution.");
        }

        public void ReCheckCopies()
        {
            Console.WriteLine("Calling a method ReCheckCopies.");
        }

        public void TranscriptGeneration()
        {
            Console.WriteLine("Calling a method TranscriptGeneration.");
        }
    }
}
