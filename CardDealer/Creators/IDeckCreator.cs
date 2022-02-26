using CardDealer.Models;

namespace CardDealer.Creators;

public interface IDeckCreator
{
    public List<ICard> CreateCardSequence();
}