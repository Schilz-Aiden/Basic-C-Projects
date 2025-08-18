using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleBlackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            bool playAgain = true;

            while (playAgain)
            {
                BlackjackGame game = new BlackjackGame();
                game.Play();

                Console.WriteLine("Do you want to play again? (y/n)");
                string input = Console.ReadLine().ToLower();
                playAgain = (input == "y");
            }
        }
    }

    public class BlackjackGame
    {
        private Deck deck;
        private Hand playerHand;
        private Hand dealerHand;

        public BlackjackGame()
        {
            deck = new Deck();
            playerHand = new Hand();
            dealerHand = new Hand();
        }

        public void Play()
        {
            // Initial deal
            playerHand.AddCard(deck.DrawCard());
            playerHand.AddCard(deck.DrawCard());
            dealerHand.AddCard(deck.DrawCard());
            dealerHand.AddCard(deck.DrawCard());

            Console.WriteLine("Dealer's visible card: " + dealerHand.Cards[0]);

            bool playerTurn = true;

            while (playerTurn)
            {
                Console.WriteLine("Your hand: " + playerHand);
                Console.WriteLine("Your total: " + playerHand.TotalValue());

                if (playerHand.TotalValue() > 21)
                {
                    Console.WriteLine("You busted! Dealer wins.");
                    return;
                }

                Console.WriteLine("Do you want to (h)it or (s)tand?");
                string input = Console.ReadLine().ToLower();

                if (input == "h")
                {
                    playerHand.AddCard(deck.DrawCard());
                }
                else if (input == "s")
                {
                    playerTurn = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please type 'h' or 's'.");
                }
            }

            // Dealer's turn
            Console.WriteLine("Dealer's hand: " + dealerHand);

            while (dealerHand.TotalValue() < 17)
            {
                dealerHand.AddCard(deck.DrawCard());
                Console.WriteLine("Dealer draws: " + dealerHand.Cards.Last());
            }

            Console.WriteLine("Dealer's total: " + dealerHand.TotalValue());

            // Determine winner
            int playerTotal = playerHand.TotalValue();
            int dealerTotal = dealerHand.TotalValue();

            if (dealerTotal > 21 || playerTotal > dealerTotal)
            {
                Console.WriteLine("You win!");
            }
            else if (playerTotal < dealerTotal)
            {
                Console.WriteLine("Dealer wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }

    public class Deck
    {
        private List<Card> cards;
        private Random rand;

        public Deck()
        {
            rand = new Random();
            cards = new List<Card>();

            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    cards.Add(new Card(suit, value));
                }
            }

            Shuffle();
        }

        public void Shuffle()
        {
            cards = cards.OrderBy(c => rand.Next()).ToList();
        }

        public Card DrawCard()
        {
            if (cards.Count == 0) throw new Exception("No more cards in the deck!");
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }

    public class Card
    {
        public string Suit { get; }
        public string Value { get; }

        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        public int GetNumericValue()
        {
            if (Value == "A") return 11;
            if (Value == "K" || Value == "Q" || Value == "J") return 10;
            return int.Parse(Value);
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }

    public class Hand
    {
        public List<Card> Cards { get; private set; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public int TotalValue()
        {
            int total = Cards.Sum(c => c.GetNumericValue());
            int aceCount = Cards.Count(c => c.Value == "A");

            // Adjust for aces
            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }

        public override string ToString()
        {
            return string.Join(", ", Cards);
        }
    }
}
