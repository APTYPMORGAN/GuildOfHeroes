public class Game
{
    public string Name;
    public string Genre;
    public int Year;
    public double Rating;
    public int Amount;

    public Game(string name, string genre, int year) {
        Name = name;
        Genre = genre;
        Year = year;
        Rating = 0.0;
        Amount = 0;
    }
    public void AddRating(double amount) {
        if (amount <= 0) {
            return;
        }
        Rating += amount;
    }

    public void AddAmount(int amount) {
        if (amount <= 0) {
            return;
        }
        Amount += amount;
    }

    public bool IsAvailaible() {
        return Amount > 0;
    }
    
    public string GetInfo() {
        return $">>> {Name} <<<\n" +
           $"Жанр: {Genre}\n" +
           $"Год выпуска: {Year}\n" +
           $"Рейтинг: {Rating}\n" +
           $"Количество на складе: {Amount}";
    }
}