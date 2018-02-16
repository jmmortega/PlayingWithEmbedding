using System;
using System.Collections.Generic;
using PlayingWithEmbedding.Core;

namespace PlayingWithEmbedding.Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Yep, I know, I can't use Result... 
            var response = new MySuperCoolClass().GetAnimeAsync("eva").Result;

            Write(response);

            Console.WriteLine("Finish!");
            Console.ReadKey();
        }

        private static void Write(List<ResultJikan> response)
        {
            foreach(var result in response)
            {
                Console.WriteLine($"Title: {result.Title}");
                Console.WriteLine($"Description: {result.Description}");
            }
        }
    }
}
