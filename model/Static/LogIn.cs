
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace OOP_lab3.model.Static
{

        public static class LogIN
    {
        public static bool _logINed { get; private set; }
        public static Account authAccount { get; private set; }
        public static List<Account> accountsList= new List<Account>();

        private static string _fileDBName = "usersDB.json";

        public static void LogOut()
        {
            _logINed = false;
            authAccount = null;
        }

        public static bool authLogIN(string loggin, string password)
        {
            Load();
            if (accountsList == null) return false;
            foreach (var account in accountsList)
            {
                if (!account.LogNPass(loggin, password)) continue;
                
                authAccount = account;
                _logINed = true;
                Refresh();
                return true;
            }
            return false;
        }

        public static void NewAccount(string loggin, string nickname, string password)
        {
            Load();
            authAccount = new Account(loggin, nickname, password);
            accountsList.Add(authAccount);
            _logINed = true;
            Refresh();
        }

        private static void Load()
        {
            string json = File.ReadAllText(_fileDBName);
            accountsList = JsonConvert.DeserializeObject<List<Account>>(json);
        }
        public static void Refresh()
        {
            string json = JsonConvert.SerializeObject(accountsList);
            File.WriteAllText(@_fileDBName, json);
        }
    }
}