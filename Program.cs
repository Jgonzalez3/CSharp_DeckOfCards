using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck NewDeck = new Deck();
            NewDeck.Deal();
            NewDeck.Reset();
            int count  = 0;
            foreach (var card in NewDeck.cards){
                count++;
                Console.WriteLine(card.stringVal + card.suit);
            }
            Console.WriteLine(count);
            Player p1 = new Player("Javier");
            p1.Draw(NewDeck);
            p1.Discard(1);
            foreach (var card in p1.hand){
                Console.WriteLine("p1 hand: " + card.stringVal + card.suit);
            }
            int newcount = 0;
            foreach (var card in NewDeck.cards){
                newcount++;
                Console.WriteLine(card.stringVal + card.suit);
            }
            Console.WriteLine(newcount);
        }
    }
}
