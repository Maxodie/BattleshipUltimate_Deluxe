namespace MyApp.Game;
using BattleshipUltimate_Deluxe.Tools;

public class Enemy
{
    private int m_hitPoints;
    private bool m_isDead;

    private EnemyType m_enemyType = EnemyType.None;
    private Vector2 m_position = Vector2.Zero();

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
