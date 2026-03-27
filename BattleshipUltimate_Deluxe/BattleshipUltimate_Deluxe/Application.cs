namespace BattleshipUltimate_Deluxe
{
    class Application
    {
        bool m_isRunning = false;
        public void Init()
        {
            m_isRunning = true;
        }

        public void Run()
        {
            while(m_isRunning)
            {
            }

            Stop();
        }

        public void Stop()
        {
            m_isRunning = false;
        }

        public void Shutdown()
        {

        }
    }
}
