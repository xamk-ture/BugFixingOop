using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingOop.Models
{
    // Problem Description:
    // The Draw method does not behave polymorphically when called on a list of shapes because
    // it's not properly overridden in derived classes.
    // Task: Ensure that the Draw method behaves polymorphically across the Shape hierarchy.
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }
}
