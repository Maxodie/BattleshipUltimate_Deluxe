using System.Diagnostics;

namespace MyApp.Game;

public class Map
{
    private Guid m_currentMapId;
    private Cell[] m_map;
    private bool m_mapExists = false;
    
    public bool MapExistsInDataBase(Guid id)
    {
        m_map = LoadMap(id);
        return false;
    }

    public void CreateMap(int mapSize) 
    {
        m_map = new Cell[mapSize];
    }

    private void FeedEnemyInfo()
    {
        
    }

    private Cell[] LoadMap(Guid id)
    {
        return new Cell[m_map.Length];
    }
}