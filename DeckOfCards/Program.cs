namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Deck Of Card");
            PlayingCards playingCards = new PlayingCards();
            playingCards.ShuffleCards();
        }
    }
}