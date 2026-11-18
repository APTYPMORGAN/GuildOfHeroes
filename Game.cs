public class Game
{
    private int _count_rating = 0;
    private double _all_rating = 0.0;
    private string _name = "Без названия";
    public string Name {
        get {
            return _name;
        }

        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _name = "Без названия";
                return;
            }

            _name = value.Trim();
    }
}
    public string Genre { get; private set; }
    public int Year { get; private set; }
    public double Rating { get; private set; }
    public int Amount { get; private set; }

    public Game(string name, string genre, int year) {
        Name = name;
        Genre = genre;
        Year = year;
        Rating = 0.0;
        Amount = 0;

        if (Amount <= 0) {
            Amount = 0;
        }

        if (Year <= 0) {
            Year = 0;
        }

        if (Rating <= 0.0) {
            Rating = 0.0;
        }

        if (Rating >= 5.0) {
            Rating = 5.0;
        }
    }
    public void AddRating(double amount) {
        if (amount <= 0 || amount > 5.0) {
            return;
        }

        _count_rating += 1;
        _all_rating += amount;
        Rating = _all_rating / _count_rating;
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