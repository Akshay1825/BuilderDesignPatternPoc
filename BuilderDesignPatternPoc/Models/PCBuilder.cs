using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternPoc.Models
{
    internal class PCBuilder:IPCBuilder
    {
        public PC pc = new PC();

        public void SetProcessor(string processor)
        {
            pc.Processor = processor;
        }

        public void SetRAM(string ram)
        {
            pc.RAM = ram;
        }

        public void SetStorage(string storage)
        {
            pc.Storage = storage;
        }

        public void SetGraphicsCard(string graphicsCard)
        {
            pc.GraphicsCard = graphicsCard;
        }

        public PC GetPC()
        {
            return pc;
        }
    }
}
