using CardDealer.Models.Enums;

namespace CardDealer.Models;

public class Card : ICard
{
    public Suits Suit { get; private set; }
    public Ranks Rank { get; private set; }

    public Card(Suits suit, Ranks value)
    {
        Suit = suit;
        Rank = value;
    }
}