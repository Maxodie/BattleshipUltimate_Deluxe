using MySqlConnector;

namespace BattleshipUltimate_Deluxe
{
    public class BattleshipUltimate_Deluxe
    {
        MySqlConnection m_connection;

        public void OpenConnection()
        {
            m_connection = new MySqlConnection($"server=81.1.20.23;user=EtudiantJvd;database=USRS6N_1;port=3306;password=!?CnamNAQ01?!");
            try
            {
                m_connection.Open();
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}