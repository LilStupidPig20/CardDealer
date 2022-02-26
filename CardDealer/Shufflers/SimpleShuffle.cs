using CardDealer.Models;

namespace CardDealer.Shufflers;

public class SimpleShuffle : IShuffleService
{
    public void Shuffle(ICardDeck deck)
    {
        var rnd = new Random();
        for (var i = deck.Cards.Count - 1; i >= 1; i--)
        { 
            var j = rnd.Next(i + 1);
            (deck.Cards[j], deck.Cards[i]) = (deck.Cards[i], deck.Cards[j]);
        }
    }
}