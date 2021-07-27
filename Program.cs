using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> suits = new List<string>() { "Spades", "Clubs", "Diamonds", "Hearts" };
            List<string> ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            List<string> deck = new List<string>();

            // creating a deck of card
            for (int suitsIndex = 0; suitsIndex < suits.Count; suitsIndex++)
            {
                for (int ranksIndex = 0; ranksIndex < ranks.Count; ranksIndex++)
                {
                    deck.Add(ranks[ranksIndex] + " of " + suits[suitsIndex]);
                }
            }

            int numberOfCards = deck.Count;

            // shuffling the deck of card
            for (int shuffleIndex = deck.Count - 1; shuffleIndex >= 1; shuffleIndex--)
            {
                System.Random randomNumberGenerator = new Random();
                int randomIndex = randomNumberGenerator.Next(shuffleIndex);

                string shuffleCard = deck[shuffleIndex];
                string randomCard = deck[randomIndex];
                deck[shuffleIndex] = randomCard;
                deck[randomIndex] = shuffleCard;
            }

            // showing the top 2 cards
            for (int cardIndex = deck.Count - 1; cardIndex > deck.Count - 3; cardIndex--)
            {
                Console.WriteLine(deck[cardIndex]);
            }

            List<string> player1Hand = new List<string>();
            List<string> player2Hand = new List<string>();

            // dealing two hands
            for (int dealIndex = 0; dealIndex % 2 == 0 && dealIndex < deck.Count; dealIndex++)
            {
                player1Hand.Add(deck[dealIndex]);
            }

            for (int dealIndex = 0; dealIndex % 2 == 1 && dealIndex < deck.Count; dealIndex++)
            {
                player2Hand.Add(deck[dealIndex]);
            }
        }
    }
}
