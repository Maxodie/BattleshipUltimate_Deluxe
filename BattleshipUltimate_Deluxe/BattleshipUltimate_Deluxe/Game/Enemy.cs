public class Enemy
{
    private int m_hitPoints;
    private bool m_isDead;

    private EnemyType m_enemyType = EnemyType.None;
    private Vector3 m_position = Vector3.Zero();

    public Enemy(EnemyType type, Vector3 position)
    {
        m_enemyType = type;
        m_position = position;
    }

    public Vector3 GetPosition()
    {
        return m_position; 
    }

    public EnemyType GetEnemyType()
    {
        return m_enemyType;
    }

    public void FeedHitPoints(int hitPoints)
    {
        m_hitPoints = hitPoints;
    }

    public void Hit()
    {
        m_hitPoints -= 1;
        if (m_hitPoints <= 0)
        {
            Kill();
        }
    }

    private void Kill()
    {
        m_isDead = true;
    }
}
