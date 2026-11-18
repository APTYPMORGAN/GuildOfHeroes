Game Witcher = new Game("Ведьмак 3: Дикая Охота", "Ролевой боевик", 2015);
Game Rdr2 = new Game("Red Dead Redemption 2", "Приключенческий боевик", 2018);
Game Cyberpunk = new Game("Cyberpunk 2077", "Ролевой боевик", 2020);

Console.WriteLine($"1. Начальный рейтинг: {Witcher.Rating}");

Witcher.AddRating(3.5);
Console.WriteLine($"2. После допустимого добавления (+3.5): {Witcher.Rating}");

Witcher.AddRating(-2.0);
Console.WriteLine($"3. После недопустимого добавления (-2.0): {Witcher.Rating} (не изменился)");

Witcher.AddRating(10.0);
Console.WriteLine($"4. После добавления +10.0 (максимум 5.0): {Witcher.Rating}");

Console.WriteLine("\n--- Проверка неправильного начального значения ---");

Game BrokenGame = new Game("   ", "Инди", -1999);
Console.WriteLine(BrokenGame.GetInfo());
Console.WriteLine();
Witcher.AddAmount(5);
Rdr2.AddAmount(4);

List<Game> games = new List<Game>();
games.Add(Witcher);
games.Add(Rdr2);
games.Add(Cyberpunk);
games.Add(new Game("Grand Theft Auto V", "Приключенческий боевик", 2013));
if (games.Count > 0)
{
    Console.WriteLine($"Количество игр в магазине: {games.Count}");
    Console.WriteLine($"Первая игра: {games[0].Name}");
    Console.WriteLine($"Последняя игра: {games[games.Count - 1].Name}");
}
Console.WriteLine();

foreach (Game game in games)
{
    Console.WriteLine(game.GetInfo());
    Console.WriteLine();
}

Console.WriteLine("--- ИГРЫ ДОСТУПНЫЕ В НАЛИЧИЕ ---");
Console.WriteLine();
int count_isavaliable = 0;
foreach (Game game in games)
{
    if (game.IsAvailaible())
    {
        Console.WriteLine(game.Name);
        count_isavaliable += 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Всего в наличие игр: {count_isavaliable}");
Console.WriteLine();
Console.WriteLine("Обращение к первой игре из списка через сам список:");
Console.WriteLine($"Количество Ведьмака на складе - {games[0].Amount}");
