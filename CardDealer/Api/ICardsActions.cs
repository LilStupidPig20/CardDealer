using CardDealer.Models;

namespace CardDealer.Api;

public interface ICardsActions
{
    public void CreateCardDeck(string name);

    public void DeleteCardDeck(string name);

    public List<string> GetAllDecksNames();

    public void ShuffleTheDeck(string name);

    public ICardDeck GetDeck(string name);
}