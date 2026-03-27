public struct Vector3
{
    public Vector3(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public int X;
    public int Y;
    public int Z;

    public static Vector3 Zero()
    {
        return new Vector3(0, 0, 0); 
    }
}