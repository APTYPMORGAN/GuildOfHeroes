public class Game
{
    public string Name;
    public string Genre;
    public int Year;
    public double Rating;

    public Game(string name, string genre, int year) {
        Name = name;
        Genre = genre;
        Year = year;
        Rating = 0.0;
    }
}