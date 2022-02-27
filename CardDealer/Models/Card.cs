using CardDealer.Models.Enums;

namespace CardDealer.Models;

public class Card : ICard
{
    public Enum Suit { get; private set; }
    public Enum Rank { get; private set; }

    public Card(Enum suit, Enum value)
    {
        Suit = suit;
        Rank = value;
    }
}