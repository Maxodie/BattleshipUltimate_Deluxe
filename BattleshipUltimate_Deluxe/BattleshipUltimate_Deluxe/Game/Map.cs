using System;

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

    public void CreateMap()
    {
        
    }

    private Cell[] LoadMap(Guid id)
    {
        return new Cell[m_map.Length];
    }
}