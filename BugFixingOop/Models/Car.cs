using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingOop
{
    // Problem Description:
    // The Car class does not correctly implement the IVehicle interface methods.
    // Task: Rename the Start and Stop methods to correctly implement the IVehicle interface.
    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }

    public class Car : IVehicle
    {
        public void Start() 
        {
            Console.WriteLine("Engine started.");
        }

        public void Stop() 
        {
            Console.WriteLine("Engine stopped.");
        }
    }
}
