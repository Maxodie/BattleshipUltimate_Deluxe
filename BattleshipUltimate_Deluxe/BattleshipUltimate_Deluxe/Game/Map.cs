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

    public void CreateMap(int mapSize, List<EnemyInfo> enemyInfos)
    {
        List<Enemy> enemies = FeedEnemyInfo(enemyInfos);
        m_map = new Cell[mapSize, mapSize, mapSize];
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
        
    }

    private Cell[,,] LoadMap(Guid id)
    {
        return new Cell[,,];
    }
}