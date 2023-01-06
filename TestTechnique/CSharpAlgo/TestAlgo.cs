using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgo
{
    public static class TestAlgo
    {
        // Faire un programme qui reconnait les palyndromes et qui sort les résultats au format:
        // madam est un palyndrome
        // tenet est un palyndrome
        // bob est un palyndrome
        public static void TestPalyndrome()
        {
            var words = new string[] {"madam", "test", "tenet", "okapi", "bob"};
        }

        // Faire un programme qui compte le nombre d'occurence de chaque lettre dans une phrase
        // Exemple de résultat: La lettre e est présente 3 fois
        public static void TestLetterOccurences()
        {
            var message = "Welcome to diggers my friend";
        }


        // Faire un programme qui pour un tableau de nombre, reconnait les nombres pairs et les nombres impairs
        // Si possible utilisé une Func pour faire la vérification
        public static void TestOddPair()
        {
            var input = new [] { 2, 7, 45, 11, 88};
        }

    }
}
