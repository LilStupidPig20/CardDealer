using CardDealer.Models;

namespace CardDealer.Context;

public class DefaultContext
{
    public List<ICardDeck> Decks { get; set; }
    
    public DefaultContext()
    {
        Decks = new List<ICardDeck>();
    }
}