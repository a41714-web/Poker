namespace Core;

public enum HandRank
{
    HighCard = 1,
    OnePair = 2,
    TwoPair = 3,
    ThreeOfAKind = 4,
    Straight = 5,
    Flush = 6,
    FullHouse = 7,
    FourOfAKind = 8,
    StraightFlush = 9,
    RoyalFlush = 10
}

public class Hand
{
    private List<Card> cards;
    private HandRank rank;

    public Hand(List<Card> newcards)
    {
        cards = newcards;
    }

    public void EvaluateHand()
    {
        //TODO: Find best 5 card poker hand
    }

    private bool CheckRoyalFlush() { /* TODO */ }
    private bool CheckStraightFlush() { /* TODO */ }
    private bool CheckFourOfAKind() { /* TODO */ }
    private bool CheckFullHouse() { /* TODO */ }
    private bool CheckFlush() { /* TODO */ }
    private bool CheckStraight() { /* TODO */ }
    private bool CheckThreeOfAKind() { /* TODO */ }
    private bool CheckTwoPair() { /* TODO */ }
    private bool CheckOnePair() { /* TODO */ }
    private void CheckHighCard() { /* TODO */ }

    public int CompareTo(HandRank other)
    {
        if( this.rank > other )
            return 1;
        else if( this.rank < other )
            return -1;
        else
            return 0;
    }
}