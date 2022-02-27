using CardDealer.Models.Enums;

namespace CardDealer.Models;

public interface ICard
{
    public Enum Rank { get; }
}