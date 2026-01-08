namespace Core;

public enum Suit { Hearts, Diamonds, Clubs, Spades }
public enum Rank { Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13, Ace = 14 }

public class Deck
{
    private List<Card> cards;
    
    public Deck()
    {
        cards = new List<Card>();
        InitializeDeck();
        Shuffle();
    }

    private void InitializeDeck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    public Card DrawCard()
    {
        if (cards.Count == 0)
            throw new InvalidOperationException("Deck is empty");
        
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }

    public int CardsRemaining => cards.Count;

    private void Shuffle()
    {
        Random rng = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            int k = rng.Next(n--);
            (cards[k], cards[n]) = (cards[n], cards[k]);
        }
    }
}