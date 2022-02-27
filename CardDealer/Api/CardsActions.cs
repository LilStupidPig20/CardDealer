using CardDealer.Models;
using CardDealer.Creators;
using CardDealer.Context;
using CardDealer.Shufflers;

namespace CardDealer.Api;

public class CardsActions : ICardsActions
{
    private IContext context;
    private IDeckCreator creator;
    private IShuffleService shuffler;

    public CardsActions(IContext context, IShuffleService shuffler, IDeckCreator creator)
    {
        this.creator = creator;
        this.shuffler = shuffler;
        this.context = context;
    }
    
    public void CreateCardDeck(string name)
    {
        if (context.Exist(name))
            throw new Exception("Already Created");
        var cards = creator.CreateCardSequence();
        context.Add(new CardDeck(name, cards));
    }

    public void DeleteCardDeck(string name)
    {
        var deck = context.Find(name);
        context.Remove(deck);
    }

    public List<string> GetAllDecksNames()
    {
        return context.FindAll();
    }

    public void ShuffleTheDeck(string name)
    {
        var deck = context.Find(name);
        if (deck == null)
            throw new Exception("Doesn't Exist");
        shuffler.Shuffle(deck);
    }

    public ICardDeck GetDeck(string name)
    {
        var deck = context.Find(name);
        if (deck == null)
            throw new Exception("Doesn't Exist");
        return deck;
    }
}