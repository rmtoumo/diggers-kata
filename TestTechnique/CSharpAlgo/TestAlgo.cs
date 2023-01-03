using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgo
{
    public static class TestAlgo
    {

        // Faire un programme qui reconnait tous les anagrames et qui sort les résultats au format:
        // anagrame 1: bao, aob
        // anagrame 2: meteor, remote
        // anagrame 3: thing, night
        // anagrame 4: marie, aimer
        public static void TestAnagram()
        {
            var words = new string[] { "bao", "aob", "meteor", "remote", "thing", "night", "marie", "aimer" };
        }


        // Faire un programme qui reconnait les palyndromes et qui sort les résultats au format:
        // madam est un palyndrome
        // tenet est un palyndrome
        // bob est un palyndrome
        public static void TestPalyndrome()
        {
            var words = new string[] {"madam", "test", "tenet", "okapi", "bob"};
        }

        // Faire un programme qui compte le nombre de lettre identiques dans une phrase
        // Exemple de résultat: La lettre e est présente 4 fois
        public static void TestLetterWeight()
        {
            var message = "Welcome to citeo my friend";
        }


        // Faire un programme qui pour un tableau de nombre, reconnait les nombres pairs et les nombres impairs
        public static void TestOddPair()
        {
            var input = new [] { 2, 7, 45, 11, 88};
        }

    }
}
