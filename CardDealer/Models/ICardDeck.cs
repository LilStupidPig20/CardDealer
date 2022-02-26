namespace CardDealer.Models;

public interface ICardDeck
{
    public string Name { get; }
    public List<ICard> Cards { get; }
}