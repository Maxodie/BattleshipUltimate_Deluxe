namespace MyApp.Game;

public class Enemy
{
    private int m_hitPoints;
    private bool m_isDead;

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
