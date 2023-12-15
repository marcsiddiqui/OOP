using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface IResultGenerator
    {
        void CheckCopies();

        void ReCheckCopies();

        void Corrections();

        void AssignMarks();

        void TranscriptGeneration();

        void PrizeDistribution();
    }
}
