﻿using System.Collections.Generic;

namespace OOP_lab3.model.Static
{

        public static class LogIN
    {
        public static bool _logINed { get; private set; }
        public static Account authAccount { get; private set; }
        public static List<Account> accountsList= new List<Account>();

        public static void LogOut()
        {
            _logINed = false;
            authAccount = null;
        }

        public static bool authLogIN(string loggin, string password)
        {
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
            authAccount = new Account(loggin, nickname, password);
            accountsList.Add(authAccount);
            _logINed = true;
            Refresh();
        }

        public static void Refresh()
        {
            
        }
    }
}