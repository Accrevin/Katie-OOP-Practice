 namespace TwentyOne
{

    class GameState
    {
        bool isPlayerTurn;
        int TurnNumber;
        bool PlayerStay;
        bool DealerStay;

    }

    class Hand
    {
        Card[] cards = new Card[] { };
    }

    class Player
    {
        string name;
        int score;
        Hand hand;
    }

    class Dealer
    {
        int score;
        Hand hand;
    }

    enum Suits {hearts, spades, clubs, diamonds};
    class Deck
    {
        Card[] cards = new Card[52];
        private Deck(Card[] cards)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < cards.Length + 1; j++)
                {
                    Card cardGenerated = new Card();
                    if (i == 0)
                    {
                        cardGenerated.suit = Suits.hearts;
                    }
                }
            }
        }
    }

    class Card
    {
        string name;
        
        int value;
        Suits suit;
        

    }

    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
