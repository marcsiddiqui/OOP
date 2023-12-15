using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    #region Abstract Class & Method

    // abstract class
    public abstract class Shape
    {
        // abstract method
        // definition only
        public abstract void Draw();

        public virtual void RemoveShape()
        {

        }

        public abstract void FillColor();
    }

    #endregion


    #region Implementation of Abstract Method

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("We are drawing a Circle.");
        }

        public override void FillColor()
        {
            Console.WriteLine("Filling colors in Circle.");
        }

        public override void RemoveShape()
        {

        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("We are drawing a Square.");
        }

        public override void FillColor()
        {
            Console.WriteLine("Filling colors in Square.");
        }
    }

    #endregion





}
