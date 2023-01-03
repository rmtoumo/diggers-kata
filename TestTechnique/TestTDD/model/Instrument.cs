using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TestTDD.model
{
    public enum InstrumentType
    {
        CORDE = 0,
        VENT,
        CLAVIER
    }
    public class Guitare
    {
        public static InstrumentType Type { get => InstrumentType.CORDE; }
    }

    public class Violon
    {
        public static InstrumentType Type { get => InstrumentType.CORDE; }
    }

    public class Piano
    {
        public static InstrumentType Type { get => InstrumentType.CLAVIER; }
    }

    public class Flute
    {
        public static InstrumentType Type { get => InstrumentType.VENT; }
    }
}
