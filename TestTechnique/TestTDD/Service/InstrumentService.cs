using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTDD.model;

namespace TestTDD.Service
{
    public interface IServiceInstrument
    {
        string PlayInstrument(InstrumentType instumentType);
    }

    public class InstrumentService : IServiceInstrument
    {
        public string PlayInstrument(InstrumentType instumentType)
        {
            throw new NotImplementedException();
        }

        private static object GetInstrumentByType(InstrumentType instumentType)
        {
            return instumentType switch
            {
                InstrumentType.CORDE => new Guitare(),
                InstrumentType.CLAVIER => new Piano(),
                InstrumentType.VENT => new Flute(),
                _ => throw new Exception("Bad instrument"),
            };
        }
    }
}
