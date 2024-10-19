using BuilderDesignPatternPoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternPoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPCBuilder pcBuilder = new PCBuilder();
            PCDirector.BuildGamingPC(pcBuilder);
            Console.WriteLine("Building Gaming PC.....");
            Console.WriteLine(pcBuilder.GetPC().ToString());

            IPCBuilder pcBuilder1 = new PCBuilder();
            PCDirector.BuildBudgetPC(pcBuilder1);
            Console.WriteLine("Building Budget PC.....");
            Console.WriteLine(pcBuilder1.GetPC().ToString());
        }
    }
}
