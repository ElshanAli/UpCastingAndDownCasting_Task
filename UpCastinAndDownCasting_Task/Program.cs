using System;

namespace UpCastinAndDownCasting_Task
{
    class Program
    {
        static void Main(string[] args)
        {NewPlace:
            Iprintable word = new Word();
            Iprintable pdf = new PDF();
            Iprintable excel = new Excel();
            MainPrintFile file = new MainPrintFile(word);
            MainPrintFile file1 = new MainPrintFile(pdf);
            MainPrintFile file2 = new MainPrintFile(excel);

            Console.WriteLine("\nChoose one of them  ");
            int Section = Convert.ToInt32(Console.ReadLine());
            switch (Section)
            {
                case 1:                    
                        if (Section == 1)
                        {
                            Console.WriteLine("  \nPrinted Word\n");
                        }
                    
                    goto NewPlace;                                    
                case 2:
                    if (Section==2)
                    {
                        Console.WriteLine("  \nPrinted PDF\n");                       
                    }
                    goto NewPlace;
                case 3:
                    if (Section==3)
                    {
                        Console.WriteLine("  \nPrinted Excel\n");                        
                    }
                   goto NewPlace;
            }
        }

      
    }
}
