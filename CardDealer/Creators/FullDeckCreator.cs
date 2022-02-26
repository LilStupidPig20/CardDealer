using CardDealer.Models;
using CardDealer.Models.Enums;

namespace CardDealer.Creators;

public class FullDeckCreator : IDeckCreator
{
    public List<ICard> CreateCardSequence()
    {
        var cards = new List<ICard>();
        for (var i = 0; i < 4; i++)
        {
            Suits currentSuit;
            switch (i)
            {
                case 0:
                    currentSuit = Suits.Clubs;
                    break;
                case 1:
                    currentSuit = Suits.Diamonds;
                    break;
                case 2:
                    currentSuit = Suits.Hearts;
                    break;
                case 3:
                    currentSuit = Suits.Spades;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            cards.AddRange(new List<ICard>
            {
                new Card(currentSuit, Ranks.Ace),
                new Card(currentSuit, Ranks.Two),
                new Card(currentSuit, Ranks.Three),
                new Card(currentSuit, Ranks.Four),
                new Card(currentSuit, Ranks.Five),
                new Card(currentSuit, Ranks.Six),
                new Card(currentSuit, Ranks.Seven),
                new Card(currentSuit, Ranks.Eight),
                new Card(currentSuit, Ranks.Nine),
                new Card(currentSuit, Ranks.Ten),
                new Card(currentSuit, Ranks.Jack),
                new Card(currentSuit, Ranks.Queen),
                new Card(currentSuit, Ranks.King)
            });
        }

        return cards;
    }
}