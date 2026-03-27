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

        
        public object[][] SQLQuery(string query)
        {
            MySqlCommand cmd = new(query);
            var reader = cmd.ExecuteReader();

            List<object[]> objects = new List<object[]>();

            while (reader.Read())
            {
                int _len = reader.FieldCount;
                object[] _result = new object[_len];

                for (int _i = 0; _i < _len; _i++)
                {
                    _result[_i] = reader[_i];
                }

                objects.Add(_result );
            }

            reader.Close();
            return objects.ToArray();
        }

        public void SQLWriter(string request)
        {
            MySqlCommand command = new(request);
            command.ExecuteNonQuery();
        }
    }
}