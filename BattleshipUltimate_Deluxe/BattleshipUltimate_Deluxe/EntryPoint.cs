namespace BattleshipUltimate_Deluxe
{
    internal class EntryPoint
    {
        static void Main(string[] args)
        {
            Application app = new();
            app.Init();
            app.Run();
            app.Shutdown();
        }
    }
}
