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
Cyberpunk.AddAmount(3);


GameStore store = new GameStore();
Console.WriteLine($"Ведьмак добавлен: {store.AddGame(Witcher)}");
Console.WriteLine($"RDR 2 добавлена: {store.AddGame(Rdr2)}");
Console.WriteLine($"Cyberpunk добавлен: {store.AddGame(Cyberpunk)}");

Game gta = new Game("Grand Theft Auto V", "Приключенческий боевик", 2013);
Console.WriteLine($"GTA добавлена: {store.AddGame(gta)}");

Game anotherWitcher = new Game(" ведьмак 3: ДИКАЯ ОХОТА ", "Ролевая игра", 2015);
Console.WriteLine($"Повтор Ведьмака добавлен: {store.AddGame(anotherWitcher)}");

Console.WriteLine();

Console.WriteLine($"Количество игр в магазине: {store.GameCount}");
Console.WriteLine();

List<Game> games = store.GetGames();

if (games.Count > 0)
{
    Console.WriteLine($"Первая игра: {games[0].Name}");
    Console.WriteLine($"Последняя игра: {games[games.Count - 1].Name}");
}

Console.WriteLine();

foreach (Game currentGame in games)
{
    Console.WriteLine(currentGame.GetInfo());
    Console.WriteLine();
}

Game? found = store.FindGameByName("  ВЕДЬМАК 3: ДИКАЯ ОХОТА ");

if (found != null)
{
    Console.WriteLine($"Найдена игра: {found.Name}");
}
else
{
    Console.WriteLine("Игра не найдена.");
}

Game? notFound = store.FindGameByName("Minecraft");

if (notFound != null)
{
    Console.WriteLine($"Найдена игра: {notFound.Name}");
}
else
{
    Console.WriteLine("Minecraft не найдена.");
}

Console.WriteLine();

Console.WriteLine("--- ИГРЫ В НАЛИЧИИ ---");
Console.WriteLine($"Всего игр в наличии: {store.CountAvailableGames()}");

Console.WriteLine();

Console.WriteLine($"Количество до удаления: {store.GameCount}");
if (games.Count > 0)
{
    Console.WriteLine($"Количество игр в магазине: {games.Count}");
    Console.WriteLine($"Первая игра: {games[0].Name}");
    Console.WriteLine($"Последняя игра: {games[games.Count - 1].Name}");
}
Console.WriteLine();

foreach (Game currentGame in games)
{
    Console.WriteLine(currentGame.GetInfo());
    Console.WriteLine();
}

Console.WriteLine("--- ИГРЫ ДОСТУПНЫЕ В НАЛИЧИЕ ---");
Console.WriteLine();
int count_isavaliable = 0;
foreach (Game currentGame in games)
{
    if (currentGame.IsAvailaible())
    {
        Console.WriteLine(currentGame.Name);
        count_isavaliable += 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Всего в наличие игр: {count_isavaliable}");
Console.WriteLine();
Console.WriteLine("Обращение к первой игре из списка через сам список:");
Console.WriteLine($"Количество Ведьмака на складе - {games[0].Amount}");

Console.WriteLine("--- ЗАКАЗ ИГРЫ ---");

Game? Cyberpunk_game = store.FindGameByName("Cyberpunk 2077");

if (Cyberpunk_game != null)
{
    GameOrder order = new GameOrder(1);

    Console.WriteLine($"Количество до заказа: {Cyberpunk_game.Amount}");

    Console.WriteLine($"Начать заказ: {order.TryStart(Cyberpunk_game)}");

    Console.WriteLine($"Начать ещё раз: {order.TryStart(Cyberpunk_game)}");

    Console.WriteLine($"Завершить заказ: {order.TryFinish()}");

    Console.WriteLine($"Завершить ещё раз: {order.TryFinish()}");

    Game? updatedGame = store.FindGameByName("Cyberpunk 2077");

    if (updatedGame != null)
    {
        Console.WriteLine($"Количество после заказа: {updatedGame.Amount}");
    }
}