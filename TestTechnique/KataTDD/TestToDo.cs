using KataTDD.service;
using Xunit;

namespace KataTDD
{
    /* Dans la classe de test ci dessous, écrire en TDD, un test qui,
    vérifie que lorsqu'on appel la méthode PlayInstrument du service _instrumentService,  le résultat de la méthode Play de l'instrument,
    contient bien la valeur expectedContainedValue.

    Tip : Cast int to Enum: YourEnum foo = (YourEnum)yourInt; */

    public class TestToDo
    {
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
