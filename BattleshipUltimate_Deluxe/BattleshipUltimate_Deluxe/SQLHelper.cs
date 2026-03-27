// 📦 On importe le package "MySqlConnector"
// 👉 Il permet à ton programme C# de communiquer avec une base de données MySQL 🗄️
using MySqlConnector;

// 🏗️ Déclaration d’un espace de noms (namespace)
// 👋 Il sert à regrouper logiquement le code (ici ton jeu "BattleshipUltimate_Deluxe")
namespace BattleshipUltimate_Deluxe
{
    // 💡 Déclaration de la classe principale
    // 🎮 Elle va gérer la connexion à la base de données du jeu
    public class BattleshipUltimate_Deluxe
    {
        // 🔌 Déclaration d’un attribut privé : une connexion MySQL
        // 💾 Cette variable va contenir l’objet de connexion à la base
        MySqlConnection m_connection;

        // 🚪 Méthode pour ouvrir la connexion à la base de données
        public void OpenConnection()
        {
            // 🧾 Création d’une instance de connexion avec toutes les infos nécessaires :
            // 🏠 Adresse du serveur (IP)
            // 👤 Nom d’utilisateur
            // 📚 Nom de la base de données
            // ⚙️ Port (par défaut 3306 pour MySQL)
            // 🔑 Mot de passe
            m_connection = new MySqlConnection($"server=81.1.20.23;user=EtudiantJvd;database=USRS6N_1;port=3306;password=!?CnamNAQ01?!");
            
            try
            {
                // ✅ Tentative d’ouverture de la connexion
                m_connection.Open();
            }
            catch (Exception ex)
            {
                // ❌ Si un problème survient (ex: mauvais mot de passe ou serveur inaccessible)
                // 🪶 On log l’erreur avec son message pour aider au débogage
                Log.Error($"Failed to open connection {ex.Message}");
                // 🚫 Et on quitte la méthode sans planter le programme
                return;
            }
        }

        // 🧹 Méthode pour fermer proprement la connexion quand on n’en a plus besoin
        public void CloseConnection()
        {
            // 🔍 On vérifie d’abord que la connexion existe (pas null)
            if(m_connection != null)
            {
                // ✅ Si oui, on la ferme proprement
                m_connection.Close();
            }
            else
            {
                // ⚠️ Sinon, on affiche un message d’erreur pour éviter une NullReferenceException 🚫
                Log.Error("Cannot close null connection");
            }
        }
    }
}