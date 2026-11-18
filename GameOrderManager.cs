public class GameOrderManager
{
    private List<GameOrder> _orders = new List<GameOrder>();

    public void AddOrder(GameOrder order)
    {
        _orders.Add(order);
    }

    public bool IsGameBusy(Game game)
    {
        foreach (GameOrder order in _orders)
        {
            if (order.Status == GameOrderStatus.Active && order.OrderedGame == game)
            {
                return true;
            }
        }

        return false;
    }

    public bool TryStart(GameOrder order, Game game)
    {
        if (IsGameBusy(game))
        {
            return false;
        }

        return order.TryStart(game);
    }
}