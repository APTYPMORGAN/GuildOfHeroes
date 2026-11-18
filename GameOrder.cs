
public class GameOrder
{
    public int Id { get; private set; }
    public Game? OrderedGame { get; private set; }
    public GameOrderStatus Status { get; private set; }

    public GameOrder(int id)
    {
        Id = id;
        OrderedGame = null;
        Status = GameOrderStatus.Open;
    }

    public bool TryStart(Game game)
    {
        if (Status != GameOrderStatus.Open || game.Amount <= 0)
        {
            return false;
        }

        OrderedGame = game;
        Status = GameOrderStatus.Active;
        return true;
    }

    public bool TryFinish()
    {
        if (Status != GameOrderStatus.Active || OrderedGame == null)
        {
            return false;
        }

        OrderedGame.RemoveAmount();
        Status = GameOrderStatus.Finished;
        return true;
    }

    public bool TryCancel()
    {
        if (Status != GameOrderStatus.Open && Status != GameOrderStatus.Active)
        {
            return false;
        }

        Status = GameOrderStatus.Cancelled;
        return true;
    }
}
