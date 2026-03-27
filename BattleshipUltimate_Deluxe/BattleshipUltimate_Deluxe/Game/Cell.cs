public class Cell
{
    private bool m_enemyInCell = false;
    private Enemy m_enemy;

    public bool IsEnemyInCell()
    {
        return m_enemyInCell;
    }

    public void Hit()
    {
        m_enemy?.Hit();
        m_enemyInCell = false;
    }
}