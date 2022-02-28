using System.Collections.Generic;
using CardDealer.Creators;
using CardDealer.Models;
using CardDealer.Shufflers;
using NUnit.Framework;

namespace CardDealer.Tests;

[TestFixture]
public class ShufflerTest
{
    private List<ICard> cards;
    private SimpleShuffle shuffler;
    
    [SetUp]
    public void Init()
    {
        cards = new FullDeckCreator().CreateCardSequence();
        shuffler = new SimpleShuffle();
    }

    [Test]
    public void IsLengthHasNotChanged()
    {
        var deck = new CardDeck("test", cards);
        shuffler.Shuffle(deck);
        Assert.AreEqual(52,deck.Cards.Count);
    }
    
    [Test]
    public void IsShuffleDontHaveSameOutputOnSameDeck()
    {
        var deck1 = new CardDeck("test", cards);
        var cards2 = new FullDeckCreator().CreateCardSequence();
        var deck2 = new CardDeck("test", cards2);
        shuffler.Shuffle(deck1);
        shuffler.Shuffle(deck2);
        Assert.AreNotEqual(deck1, deck2);
    }
}