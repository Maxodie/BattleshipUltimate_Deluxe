namespace BattleshipUltimate_Deluxe.Tools;

public struct Vector2
{
    public Vector2(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X;
    public int Y;

    public static Vector2 Zero()
    {
        return new Vector2(0, 0); 
    }
}