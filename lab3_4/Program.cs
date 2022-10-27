using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ApplicationLicense
{
        public void AllowTrial()
        {
                Console.WriteLine("Триальний режим");
        }

        public void AllowCommon()
        {
                Console.WriteLine("Безкоштовна версiя");
        }

        public void AllowPro()
        {
                Console.WriteLine("Платна версія");
        }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        ApplicationLicense al = new ApplicationLicense();
        while (true)
        {
            Console.WriteLine("Введіть ключ: ");
            switch(Console.ReadLine())
            {
                case "trial": al.AllowTrial();
                    break;
                case "pro": al.AllowPro(); 
                    break;
                case "": al.AllowCommon(); 
                    break;
            }
        }
    }
}
