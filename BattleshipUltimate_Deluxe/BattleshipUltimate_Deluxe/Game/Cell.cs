namespace MyApp.Game;

public class Cell
{
    private bool m_hasEnemyShip = false;

    public bool IsEnemyInCell()
    {
        return m_hasEnemyShip;
    }
}