using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastinAndDownCasting_Task
{
    class PDF : Iprintable
    {
        public void PrintFile()
        {
            Console.WriteLine("Printed PDF");
        }
    }
}
