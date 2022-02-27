using CardDealer.Models.Enums;

namespace CardDealer.Models;

public class CardDeck : ICardDeck
{
    public string Name { get; private set; }
    public List<ICard> Cards { get; private set; }

    public CardDeck(string name, List<ICard> cards)
    {
        Name = name;
        Cards = cards;
    }
}