using System;

namespace Program
{
    class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
    }

    class CardDeck
    {
        //Create a new deck of cards
        static List<Card> CreateDeck()
        {
            string[] suits = { "Cloves", "Diamond", "Heart", "Spades" };
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            List<Card> cards = new List<Card>();
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    cards.Add(new Card { Suit = suit, Rank = rank});
                }
            }
            Console.WriteLine("New Deck Created!\n");
            return cards;
        }

        //Displays the current deck
        static void displayDeck(List<Card> Cards)
        {
            if (Cards.Count != 0)
            {
                foreach (var card in Cards)
                {
                    Console.WriteLine("Suit: " + card.Suit + "; Rank: " + card.Rank);
                }
            }
            Console.WriteLine("Number of Cards: " + Cards.Count + "\n");
        }

        //Run the deal deck
        static void dealDeck(List<Card> Cards)
        {
            Console.Write("How Many Cards? ");
            int count = Convert.ToInt32(Console.ReadLine());
            if (count < Cards.Count)
            {
                for(int i = 0; i < count; i++)
                {
                    Console.WriteLine("Suit: " + Cards[Cards.Count - 1].Suit + "; Rank: " + Cards[Cards.Count - 1].Rank);
                    Cards.RemoveAt(Cards.Count - 1);
                }
            } else
            {
                Console.WriteLine("Cannot deal if deck has less cards than the asked number");
            }
        }

        //Shuffle
        static void shuffleDeck(List<Card> Cards)
        {
            Console.WriteLine("Hello World! Shuffling time");
        }

        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            int choice;

            do
            {
                Console.WriteLine("Deck of Cards\n" +
                                  "1 - Create\n" +
                                  "2 - Shuffle\n" +
                                  "3 - Deal\n" + 
                                  "4 - Display Deck\n" +
                                  "5 - Exit Program");
                Console.Write("Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        cards = CreateDeck();
                        break;
                    case 2:
                        shuffleDeck(cards);
                        break;
                    case 3:
                        dealDeck(cards);
                        break;
                    case 4:
                        displayDeck(cards);
                        break;
                    default:
                        Console.WriteLine("Exited Program...");
                        break;

                }
            } while (choice != 5);
        }
    }
}