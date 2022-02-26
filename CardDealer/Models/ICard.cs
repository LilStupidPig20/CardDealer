using CardDealer.Models.Enums;

namespace CardDealer.Models;

public interface ICard
{
    public Suits Suit { get; }
    public Ranks Rank { get; }
}