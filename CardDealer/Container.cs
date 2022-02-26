using CardDealer.Api;
using CardDealer.Creators;
using CardDealer.Models;
using CardDealer.Shufflers;
using Ninject;

namespace CardDealer;

public class Container
{
    public Container()
    {
        var container = new StandardKernel();
        container.Bind<ICard>().To<Card>();
        container.Bind<ICardDeck>().To<CardDeck>();
        container.Bind<IShuffleService>().To<SimpleShuffle>();
        container.Bind<IDeckCreator>().To<FullDeckCreator>();
        container.Bind<ICardsActions>().To<CardsActions>();
    }
}