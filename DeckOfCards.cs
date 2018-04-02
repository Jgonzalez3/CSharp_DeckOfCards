using System;
using System.Collections.Generic;
namespace DeckOfCards{
    public class Card{
        public string stringVal;
        public string suit;
        public int val;
        public Card(string name, string suitType, int value){
            stringVal = name;
            suit = suitType;
            val = value;
        }
    }
    public class Deck{
        public List<Card> cards;
        
        public Deck(){
            CreateDeck();
            Shuffle();
        }
        public void CreateDeck(){
            cards = new List<Card>();
            string[] suits = {"Clubs", "Hearts", "Diamonds", "Spades"};
            string[] cardname = {"Ace","2","3","4","5","6","7","8", "9","10","Jack","Queen","King"};
            foreach( string suit in suits){
                for (int i = 0; i < 13; i++){
                    cards.Add(new Card(cardname[i], suit, i));
                }
            }
        }
        public Card Deal(){
            Card topcard = cards[0];
            if (cards.Count > 0){
                cards.Remove(topcard);
            }
            return topcard;
        }
        public void Reset(){
            cards = new List<Card>();
            CreateDeck();
            Shuffle();
        }
        public void Shuffle(){
            Random rand = new Random();
            for(int idx = 0; idx < cards.Count-1; idx++){
                int swap = rand.Next(0,52);
                Card cardswap = cards[idx];
                Card temp = cards[swap];
                cards[swap] = cardswap;
                temp = cards[idx];
            }
        }
    }
    public class Player{
        public string name;
        public List<Card> hand;
        public Player(string player){
            name = player;
            hand = new List<Card>();
        }
        public Card Draw(Deck cards){
            Card newcard = cards.Deal(); 
            hand.Add(newcard);
            return newcard;
        }
        public Card Discard(int card){
            if (card < 0 || card > hand.Count- 1){
                Console.WriteLine("null");
                return null;
            }
            else{
                Card temp = hand[card];
                hand.Remove(temp);
                return temp;
            }
        }
    }
}