using CardDealer.Models;

namespace CardDealer.Context;

public class DefaultContext : IContext
{
    public List<ICardDeck> Decks { get; private set; }
    
    public DefaultContext()
    {
        Decks = new List<ICardDeck>();
    }

    public void Add(ICardDeck deck)
    {
        Decks.Add(deck);
    }

    public void Remove(ICardDeck deck)
    {
        Decks.Remove(deck);
    }

    public bool Exist(string name)
    {
        return Decks.Exists(x => x.Name == name);
    }

    public ICardDeck Find(string name)
    {
        if (!Exist(name))
            throw new Exception("Doesn't Exist");
        return Decks.Find(x => x.Name == name);
    }

    public List<string> FindAll()
    {
        return Decks.Select(x => x.Name).ToList();
    }
}