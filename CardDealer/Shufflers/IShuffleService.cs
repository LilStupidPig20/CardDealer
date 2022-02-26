using CardDealer.Models;

namespace CardDealer.Shufflers;

public interface IShuffleService
{
    public void Shuffle(ICardDeck deck);
}