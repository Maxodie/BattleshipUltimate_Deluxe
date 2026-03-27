namespace MyApp.Game;

public class Map
{
    private Guid m_currentMapId;
    private Cell[] m_map;
    private bool m_mapExists = false;
    
    public bool MapExistsInDataBase(Guid id)
    {
        //something something check id in db or something 
        m_map = LoadMap(id);
        return false;
    }

    public void CreateMap()
    {
        
    }

    private Cell[] LoadMap(Guid id)
    {
        //do the thing so the client is like doing its thing
        return new Cell[m_map.Length];
    }
}