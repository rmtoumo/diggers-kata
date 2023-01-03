using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTDD.model;
using TestTDD.Service;
using Xunit;

namespace TestTDD
{
    /* Dans la classe de test ci dessous, écrire en TDD, un test qui,
    Vérifie que lorsqu'on appel la méthode PlayInstrument du service _instrumentService,  le résultat de la méthode Play de l'instrument,
    contient bien la valeur expectedContainedValue.

    Tip : Cast int to Enum: YourEnum foo = (YourEnum)yourInt; */

    public class TestToDo
    {
        private IServiceInstrument _instrumentService;
        [Theory]
        [InlineData(0, "guitare")]
        [InlineData(0, "violon")]
        [InlineData(1, "piano")]
        [InlineData(2, "flute")]
        public void Should_Play_The_Right_Music(int instrumentType, string expectedContainedValue)
        {
        }
    }
}
