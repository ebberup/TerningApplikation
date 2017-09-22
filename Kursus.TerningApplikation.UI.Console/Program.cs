using Kursus.TerningApplikation.TerningKerne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus.TerningApplikation.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            System.Console.WriteLine(t.ToString());

            Terninger b = new Terninger(5);
            System.Console.WriteLine(b.ToString());
        }
    }
}
