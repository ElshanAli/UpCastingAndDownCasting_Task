using System;

namespace UpCastinAndDownCasting_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Iprintable word = new Word();
            Iprintable pdf = new PDF();
            Iprintable excel = new Excel();
            MainPrintFile file = new MainPrintFile(word);
            MainPrintFile file1 = new MainPrintFile(pdf);
            MainPrintFile file2 = new MainPrintFile(excel);
        }
    }
}
