using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Work with Language-Integrated Query (LINQ)
            // https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq
            // Lambda expressions
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

            // linq:
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck)
            {
                Console.WriteLine($"Startingdeck: {card}");
            }

            // lambda
            var startingDeckLambda = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));
            foreach (var card in startingDeckLambda)
            {
                Console.WriteLine($"Startingdeck lambda: {card}");
            }


            // select all hearts from deck
            var hearts = from card in startingDeck
                         where card.Suit == "hearts"
                         select card;
            
            foreach (var card in hearts)
            {
                Console.WriteLine($"Hearts: {card}");

            }

            var heartsLamda = startingDeck.Where(c => c.Suit == "hearts");
            foreach (var card in heartsLamda)
            {
                Console.WriteLine($"Heartslambda: {card}");
            }


        }

        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
