public class GameOrder
{
    public int Id { get; private set; }

    private Game? _game;
    private bool _isFinished;

    public GameOrder(int id)
    {
        Id = id;
        _game = null;
        _isFinished = false;
    }

    public bool TryStart(Game game)
    {
        if (_game != null || game.Amount <= 0)
        {
            return false;
        }

        _game = game;
        return true;
    }

    public bool TryFinish()
    {
        if (_game == null || _isFinished)
        {
            return false;
        }

        _game.RemoveAmount();
        _isFinished = true;
        return true;
    }
}