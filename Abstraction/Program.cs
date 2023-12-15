using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // base class object can be created from child class constructor
            Shape circle = new Circle();
            circle.Draw();
            circle.FillColor();
            circle.RemoveShape();

            // base class object can be created from child class constructor
            Shape square = new Square();
            square.Draw();
            square.FillColor();
            square.RemoveShape();

            //Square square1 = new Shape();

            ResultGenerator resultGenerator = new ResultGenerator();

            resultGenerator.AssignMarks();
            resultGenerator.CheckCopies();
            resultGenerator.Corrections();
            resultGenerator.PrizeDistribution();
            resultGenerator.ReCheckCopies();
            resultGenerator.TranscriptGeneration();


            Application.Run(new Form1());
        }
    }
}
