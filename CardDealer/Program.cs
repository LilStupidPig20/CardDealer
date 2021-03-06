using CardDealer.Api;
using CardDealer.Context;
using CardDealer.Creators;
using CardDealer.Shufflers;

namespace CardDealer;

public class Program
{
    public static void Main()
    {
        var context = new DefaultContext();
        var api = new CardsActions(context, new SimpleShuffle(), new FullDeckCreator());
        api.CreateCardDeck("first");
        api.CreateCardDeck("second");
        api.CreateCardDeck("third");
        api.CreateCardDeck("fourth");
        api.DeleteCardDeck("third");
        var names = api.GetAllDecksNames();
        api.ShuffleTheDeck("second");
        var f = api.GetDeck("first");
        var s = api.GetDeck("second");
        var ff = api.GetDeck("fourth");
        Console.WriteLine("FINISHED");
    }
}