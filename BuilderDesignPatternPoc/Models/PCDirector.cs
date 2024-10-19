using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternPoc.Models
{
    internal class PCDirector
    {
        public static void BuildGamingPC(IPCBuilder builder)
        {
            builder.SetProcessor("Intel i7");
            builder.SetRAM("32GB DDR4");
            builder.SetStorage("1TB SSD");
            builder.SetGraphicsCard("NVIDIA RTX 4090");
        }

        public static void BuildBudgetPC(IPCBuilder builder)
        {
            builder.SetProcessor("Intel i5");
            builder.SetRAM("8GB DDR4");
            builder.SetStorage("512GB SSD");
            builder.SetGraphicsCard("NVIDIA GTX 1660");
        }
    }
}
