using CardDealer.Api;

namespace CardDealer.Ui;

public class ConsoleUi
{
    private ICardsActions api;

    public ConsoleUi(ICardsActions api)
    {
        this.api = api;
    }
    
    public void Start()
    {
        Console.WriteLine("Инструкция:");
        while (true)
        {
            Console.WriteLine("1 - Создать колоду");
            Console.WriteLine("2 - Удалить колоду");
            Console.WriteLine("3 - Получить названия всех колод");
            Console.WriteLine("4 - Перетасовать колоду");
            Console.WriteLine("5 - Получить колоду");
            Console.WriteLine("6 - Выйти");
            var input = Console.ReadLine();
            if (input.Equals("6"))
                break;
            Menu(input);
            Console.WriteLine("_________________________________________");
        }
    }

    private void Menu(string input)
    {
        switch (input)
        {
            case "1":
                AddAction();
                break;
            case "2":
                DeleteAction();
                break;
            case "3":
                GetAllNamesAction();
                break;
            case "4":
                ShuffleAction();
                break;
            case "5":
                GetDeckAction();
                break;
            default:
                throw new Exception("IncorrectInput");
        }
    }

    private void AddAction()
    {
        Console.WriteLine("Введите название для колоды");
        var name = Console.ReadLine();
        api.CreateCardDeck(name);
    }
    
    private void DeleteAction()
    {
        Console.WriteLine("Введите название колоды");
        var name = Console.ReadLine();
        api.DeleteCardDeck(name);
    }
    
    private void GetAllNamesAction()
    {
        var decks = api.GetAllDecksNames();
        foreach (var e in decks)
        {
            Console.WriteLine(e);
        }
    }
    
    private void ShuffleAction()
    {
        Console.WriteLine("Введите название колоды");
        var name = Console.ReadLine();
        api.ShuffleTheDeck(name);
    }
    
    private void GetDeckAction()
    {
        Console.WriteLine("Введите название колоды");
        var name = Console.ReadLine();
        var deck = api.GetDeck(name);
        foreach (var e in deck.Cards)
        {
            Console.WriteLine($"{e.Rank}");
        }
    }
}