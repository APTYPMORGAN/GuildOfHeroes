Game Witcher = new Game("Ведьмак 3: Дикая Охота", "Ролевой боевик", 2015);

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