using KataTDD.model;
using System;

namespace KataTDD.service
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

        private object  InstrumentFactory(InstrumentType instumentType)
        {

            return instumentType switch
            {
                InstrumentType.CORDE => new Piano(),
                InstrumentType.PERCUSSION => new Tambour(),
                InstrumentType.VENT => new Flute(),
                _ => throw new Exception("Bad instrument"),
            };
        }
        
    }
}
