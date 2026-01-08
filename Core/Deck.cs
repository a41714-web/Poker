namespace Core;

public class Deck
{
    private List<Card> cards;
    private readonly EnumSet<Suit> suits = {"Hearts", "Diamonds", "Clubs", "Spades"};
    private readonly EnumSet<Rank> ranks = {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
    public Deck()
    {
        cards = new List<Card>();
        InitializeDeck();
        Shuffle();
    }

    private void InitializeDeck()
    {
        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    private void Shuffle()
    {
        Random rng = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            int k = rng.Next(n--);
            Card temp = cards[n];
            cards[n] = cards[k];
            cards[k] = temp;
        }
    }
}