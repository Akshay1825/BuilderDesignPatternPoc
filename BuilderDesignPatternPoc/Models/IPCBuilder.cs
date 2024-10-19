using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternPoc.Models
{
    internal interface IPCBuilder
    {
        void SetProcessor(string processor);
        void SetRAM(string ram);
        void SetStorage(string storage);
        void SetGraphicsCard(string graphicsCard);
        PC GetPC();
    }
}
