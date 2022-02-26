using CardDealer.Models;
using CardDealer.Creators;
using CardDealer.Context;
using CardDealer.Shufflers;

namespace CardDealer.Api;

public class CardsActions : ICardsActions
{
    private DefaultContext context;
    private IDeckCreator creator;
    private IShuffleService shuffler;

    public CardsActions(DefaultContext context, IShuffleService shuffler, IDeckCreator creator)
    {
        this.creator = creator;
        this.shuffler = shuffler;
        this.context = context;
    }
    
    public void CreateCardDeck(string name)
    {
        if (context.Decks.Exists(x => x.Name == name))
            throw new Exception("Already Created");
        var cards = creator.CreateCardSequence();
        context.Decks.Add(new CardDeck(name, cards));
    }

    public void DeleteCardDeck(string name)
    {
        var deck = context.Decks.Find(x => x.Name == name);
        if (deck == null)
            throw new Exception("Doesn't Exist");
        context.Decks.Remove(deck);
    }

    public List<string> GetAllDecksNames()
    {
        return context.Decks.Select(x => x.Name).ToList();
    }

    public void ShuffleTheDeck(string name)
    {
        var deck = context.Decks.Find(x => x.Name == name);
        if (deck == null)
            throw new Exception("Doesn't Exist");
        shuffler.Shuffle(deck);
    }

    public ICardDeck GetDeck(string name)
    {
        var deck = context.Decks.Find(x => x.Name == name);
        if (deck == null)
            throw new Exception("Doesn't Exist");
        return deck;
    }
}