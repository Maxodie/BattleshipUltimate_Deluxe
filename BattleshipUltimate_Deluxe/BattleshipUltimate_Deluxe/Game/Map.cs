public class Map
{
    private Guid m_currentMapId;
    private Cell[,,] m_map;
    private bool m_mapExists = false;
    private Random m_random = new Random();
    
    public bool MapExistsInDataBase(Guid id)
    {
        m_map = LoadMap(id);
        return false;
    }
    
    private Cell[,,] LoadMap(Guid id)
    {
        return new Cell[m_map.GetLength(0), m_map.GetLength(1), m_map.GetLength(2)];
    }

    public void CreateMap(int mapSize, List<EnemyInfo> enemyInfos)
    {
        List<Enemy> enemies = FeedEnemyInfo(enemyInfos);
        m_map = new Cell[mapSize, mapSize, mapSize];
        PositionEnemies(m_map, enemies);
    }

    private List<Enemy> FeedEnemyInfo(List<EnemyInfo> enemyInfos)
    {
        List<Enemy> enemies = new List<Enemy>();

        foreach (EnemyInfo info in enemyInfos)
        {
            Vector3 position = new Vector3();
            position.X = m_random.Next(0, m_map.GetLength(0));
            position.X = m_random.Next(0, m_map.GetLength(1));
            position.X = m_random.Next(0, m_map.GetLength(2));
            
            enemies.Add(new Enemy(info.EnemyType, position));    
        }
        
        return enemies;
    }

    private void PositionEnemies(Cell[,,] map, List<Enemy> enemies)
    {
        Vector3 currentPosition;
        Vector3 forward = Vector3.Zero();
        EnemyType enemyType = EnemyType.None;
        
        foreach (Enemy enemy in enemies)
        {
            enemyType = enemy.GetEnemyType();
            currentPosition = enemy.GetPosition();
            
            if (enemyType != EnemyType.Cube)
            {
                forward = RandomForward();
            }

            switch (enemyType)
            {
                case EnemyType.Segment:
                    PositionSegment(forward, map, enemy);
                    break;
                case EnemyType.Square:
                    PositionSquare(forward, map, enemy);
                    break;
                case EnemyType.Cube:
                    PositionCube(forward, map, enemy);
                    break;
                case EnemyType.None:
                    //get rekt nerd, you don't even exist lmao
                    break;
            }
        }
    }

    private void PositionSegment(Vector3 forward, Cell[,,] map, Enemy enemy)
    {
        
    }

    private void PositionSquare(Vector3 forward, Cell[,,] map, Enemy enemy)
    { 
        
    }
    
    private void PositionCube(Vector3 forward, Cell[,,] map, Enemy enemy)
    {
        
    }
    
    private Vector3 RandomForward()
    {
        int coin = m_random.Next(0, 3);

        switch (coin)
        {
            case 0:
                return new Vector3(1, 0, 0);
            case 1:
                return new Vector3(0, 1, 0);
            case 2:
                return new Vector3(0, 0, 1);
            default:
                return new Vector3(0, 0, 1);
        }
    }
}
