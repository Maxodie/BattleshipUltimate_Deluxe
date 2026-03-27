namespace MyApp.Game;

public class Cell
{
    private bool m_enemyInCell = false;
    private Enemy m_enemy;

    public bool IsEnemyInCell()
    {
        return m_enemyInCell;
    }
}