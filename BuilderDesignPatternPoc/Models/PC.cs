using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternPoc.Models
{
    internal class PC
    {
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GraphicsCard { get; set; }

        public override string ToString()
        {
            return $"PC with Processor: {Processor}\n" +
                $"RAM: {RAM}\n" +
                $"Storage: {Storage}\n" +
                $"Graphics Card: {GraphicsCard}\n";   
        }
    }
}
