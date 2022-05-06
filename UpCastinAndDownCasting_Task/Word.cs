using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastinAndDownCasting_Task
{
    class Word : Iprintable
    {
        public void PrintFile()
        {
            Console.WriteLine("Printed Word");
        }
    }
}
