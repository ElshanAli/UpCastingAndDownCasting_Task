using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastinAndDownCasting_Task
{
    class MainPrintFile
    {
        public MainPrintFile(Iprintable print)
        {
            print.PrintFile();
        }
    }
}
