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
                Log.Error($"Failed to open connection {ex.Message}");
                return;
            }
        }

        public void CloseConnection()
        {
            if(m_connection != null)
            {
                m_connection.Close();
            }
            else
            {
                Log.Error("Cannot close null connection");
            }
        }

        string RequestDataReader(string request)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(request);
                MySqlDataReader rdr = (MySqlDataReader)cmd.ExecuteReader();
                rdr.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}