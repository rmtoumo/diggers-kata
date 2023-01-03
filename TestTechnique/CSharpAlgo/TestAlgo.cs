using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgo
{
    public static class TestAlgo
    {
        public static void Test1()
        {
            //var words = new string[] { "bao", "abab", "aob", "meteor", "remote", "thing", "night", "marie", "aimer"};

            //var results  = new Dictionary;


            //var tt = words.Select(w => w.ToCharArray()).ToList();


            //foreach (var item in words)
            //{
            //    if(results.Any(i => i.Length.Equals(item.Length)))
            //    {
            //       foreach(var r in results)
            //        {
            //            var rLetters = r.ToCharArray();
            //            if(item.All(i => rLetters.Contains(i)))
            //            {

            //            }
            //        }


            //    }
            //}

        }
        
        public static void Test2()
        {
            var words = new string[] {"madam", "test", "tenet", "okapi", "bob"};


            foreach (var word in words)
            {
                var pal = string.Empty;
                var wordChars = word.ToCharArray();
                for(var i = wordChars.Length - 1; i  >= 0 ; i --)
                {
                    pal += wordChars[i];
                    if (pal.Equals(word))
                    {
                        Console.WriteLine($"{word} est un palyndrome");
                    } 
                }
            }
        }
        
        public static void Test3()
        {
            var message = "Welcome to citeo my friend";
            var t = message.ToCharArray();
            var tt = t.GroupBy(c => c);
            foreach (var r  in tt)
            {
                Console.WriteLine($"Lettre : {r.Key.ToString()} apparait: {r.Count()}");
            }
        }
        
        public static void Test4()
        {
            var input = new [] {1, 2, 7, 8, 11, 7};
            var sum = 20;
        }

    }
}
