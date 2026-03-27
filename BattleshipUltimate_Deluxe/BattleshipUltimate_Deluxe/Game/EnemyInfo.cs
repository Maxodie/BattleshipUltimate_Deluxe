public class EnemyInfo
{
    public EnemyInfo(EnemyType enemyType, int size, int amount)
    {
        this.EnemyType = enemyType;
        this.Size = size;
        this.Amount = amount;
    }
    
    public EnemyType EnemyType;
    public int Size;
    public int Amount; 
}

public enum EnemyType
{
    Segment,
    Square,
    Cube,
    None
}