using System;
using TDDKata.model;

namespace TDDKata.service
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

        private object FakeInstrumentDbFactory(InstrumentType instrumentType) => instrumentType switch
        {
            InstrumentType.CORDE => new Piano(),
            InstrumentType.PERCUSSION => new Tambour(),
            InstrumentType.VENT => new Flute(),
            _ => throw new Exception("Bad instrument"),
        };

    }
}
