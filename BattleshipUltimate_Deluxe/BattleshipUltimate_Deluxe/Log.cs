// 📦 On importe la librairie MySqlConnector (même si ici elle n’est pas utilisée directement)
// 💭 Elle est probablement là par cohérence avec le reste du projet
using MySqlConnector;

// 🏗️ Déclaration du namespace principal (le même que le projet : BattleshipUltimate_Deluxe)
namespace BattleshipUltimate_Deluxe
{
    // 🧾 Classe "Log" : elle sert à afficher des messages colorés dans la console 🎨
    public class Log
    {
        // 🎨 Tableau de couleurs ANSI utilisées dans le terminal (pour colorer le texte)
        // 👉 Chaque couleur correspond à un niveau de log (debug, success, warning, error, etc.)
        static readonly string[] s_colors = {
            "\x1b[0m",      // ⚫ Reset / Couleur par défaut (LOG_DEBUG)
            "\x1b[0m",      // ⚪ Identique pour TRACE
            "\x1b[32m",     // 🟢 Vert : SUCCESS ✅
            "\x1b[1;33m",   // 🟡 Jaune : WARNING ⚠️
            "\x1b[31m"      // 🔴 Rouge : ERROR ❌
        };

        // 🧩 Définition d’une énumération interne pour classer les types de logs 📋
        enum LogLevel
        {
            LOG_DEBUG,     // 🔍 Détails techniques, utile pour le débogage
            LOG_TRACE,     // 🧭 Pour suivre le déroulement général du programme
            LOG_SUCCESS,   // ✅ Pour signaler une opération réussie
            LOG_WARNING,   // ⚠️ Pour afficher un avertissement sans bloquer le programme
            LOG_ERROR,     // ❌ Pour les erreurs sérieuses
            LOG_LEVEL_LEN  // 📏 (optionnel, peut servir pour compter le nombre de niveaux)
        };

        // 🎯 Méthode privée Prefix() qui retourne la couleur associée au niveau du log
        static string Prefix(LogLevel logLevel)
        {
            // 🪄 On convertit le niveau du log en index numérique, puis on récupère la couleur correspondante
            return s_colors[(int)logLevel];
        }

        // ✏️ Méthode pour afficher un message de debug (gris neutre) 💻
        public static void Debug(string msg)
        {
            Console.WriteLine(Prefix(LogLevel.LOG_DEBUG) + msg);
        }

        // 🔍 Méthode pour afficher un message de trace (neutre aussi) 🔎
        public static void Trace(string msg)
        {
            Console.WriteLine(Prefix(LogLevel.LOG_TRACE) + msg);
        }

        // ✅ Méthode pour les messages de succès (en vert 🟢)
        public static void Success(string msg)
        {
            Console.WriteLine(Prefix(LogLevel.LOG_SUCCESS) + msg);
        }

        // ⚠️ Méthode pour les avertissements (en jaune 🟡)
        public static void Warning(string msg)
        {
            Console.WriteLine(Prefix(LogLevel.LOG_WARNING) + msg);
        }

        // ❌ Méthode pour les erreurs (en rouge 🔴)
        public static void Error(string msg)
        {
            Console.WriteLine(Prefix(LogLevel.LOG_ERROR) + msg);
        }
    } 
}