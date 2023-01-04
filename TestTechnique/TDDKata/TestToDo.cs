using System;
using TDDKata.service;
using Xunit;

namespace TDDKata
{
    public class TestToDo
    {
        /* Dans la classe de test ci dessous, �crire en TDD, un test qui,
            v�rifie que lorsqu'on appel la m�thode PlayInstrument du service _instrumentService,  le r�sultat de la m�thode Play de l'instrument,
            contient bien la valeur expectedContainedValue.

            Tip : Cast int to Enum: YourEnum foo = (YourEnum)yourInt; */


        private IServiceInstrument _instrumentService;
        [Theory]
        [InlineData(0, "piano")]
        [InlineData(1, "flute")]
        [InlineData(2, "tambour")]
        public void Should_Play_The_Right_Music(int instrumentType, string expectedContainedValue)
        {
        }

    }
}
