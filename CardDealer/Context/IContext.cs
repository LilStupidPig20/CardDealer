using CardDealer.Models;

namespace CardDealer.Context;

public interface IContext
{
    public void Add(ICardDeck deck);

    public void Remove(ICardDeck deck);

    public bool Exist(string name);

    public ICardDeck Find(string name);

    public List<string> FindAll();
}