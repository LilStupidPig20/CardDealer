using CardDealer.Models;
using CardDealer.Models.Enums;

namespace CardDealer.Creators;

public class FullDeckCreator : IDeckCreator
{
    public List<ICard> CreateCardSequence()
    {
        var cards = new List<ICard>();

        foreach (var suit in Enum.GetValues(typeof(Suits)))
        {
            var partOfDeck = new List<ICard>();
            foreach (var rank in Enum.GetValues(typeof(Ranks)))
            {
                partOfDeck.Add(new Card((Suits)suit, (Ranks)rank));
            }
            
            cards.AddRange(partOfDeck);
        }

        return cards;
    }
}