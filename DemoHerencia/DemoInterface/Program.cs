using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook note = new Notebook();
            Lapiz lapiz = new Lapiz();
            note.escribir("Hello ");
            lapiz.escribir("lapislazuli ");


            Console.ReadKey();
        }
    }
}
