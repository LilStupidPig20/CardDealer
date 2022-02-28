using System;
using System.Collections.Generic;
using CardDealer.Creators;
using CardDealer.Models.Enums;
using NUnit.Framework;

namespace CardDealer.Tests;

[TestFixture]
public class CreatorTest
{
    private FullDeckCreator creator;

    [SetUp]
    public void Init()
    {
        creator = new FullDeckCreator();
    }
    
    [Test]
    public void IsNotEmptyDeck()
    {
        Assert.IsNotEmpty(creator.CreateCardSequence());
    }

    [Test]
    public void IsLengthCorrect()
    {
        var cards = creator.CreateCardSequence();
        Assert.AreEqual(52, cards.Count);
    }

    [Test]
    public void AreCardsOfAllSuitsHaveTheSameCount()
    {
        var dict = new Dictionary<Enum, int>();
        foreach (var e in creator.CreateCardSequence())
        {
            if (!dict.ContainsKey(e.Rank))
                dict.Add(e.Rank, 1);
            else dict[e.Rank]++;
        }

        foreach (var e in dict)
        {
            Assert.AreEqual(4, e.Value);
        }
    }
}