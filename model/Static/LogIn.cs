
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace OOP_lab3.model.Static
{

        public class LogIN
    {
        public bool _logINed { get; private set; }
        public Account authAccount { get; private set; }
        public List<Account> accountsList= new List<Account>();
        private const string _fileDBName = "usersDB.json";
        private static LogIN LogIn = null;

        public static LogIN Initializate()
        {
            if (LogIn == null) LogIn = new LogIN();
            return LogIn;
        }

        public void LogOut()
        {
            _logINed = false;
            authAccount = null;
        }

        public bool authLogIN(string loggin, string password)
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

        public void NewAccount(string loggin, string nickname, string password)
        {
            Load();
            authAccount = new Account(loggin, nickname, password);
            accountsList.Add(authAccount);
            _logINed = true;
            Refresh();
        }

        private void Load()
        {
            string json = File.ReadAllText(_fileDBName);
            accountsList = JsonConvert.DeserializeObject<List<Account>>(json);
        }
        public void Refresh()
        {
            string json = JsonConvert.SerializeObject(accountsList);
            File.WriteAllText(@_fileDBName, json);
        }
    }
}