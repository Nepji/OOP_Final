using System.Collections.Generic;
using OOP_lab3.model.Static;

namespace OOP_lab3.model
{
    public partial class Account : DTO.Account_DTO
    {
        public List<HistoryNote> historyNotes { get; protected set; }
        private const int BasicRating = 700;
        
        public Account(string login, string nickname, string password)
        {
            this.login = login;
            this.nickname = nickname;
            this.password = password;
            this.GamesCount = 0;
            historyNotes = new List<HistoryNote>();
        }

        public Account(Account copy)
        {
            this.login = copy.login;
            this.nickname = copy.nickname;
            this.password = copy.password;
            this.GamesCount = copy.GamesCount;
            this.historyNotes = copy.historyNotes;
        }

        public void addHistoryNote(int countoflives, int maxlevelofgame)
        {
            this.historyNotes.Add(new HistoryNote(countoflives,maxlevelofgame,historyNotes.Count));
            GamesCount++;
            LogIN.Refresh();
        }

        public bool LogNPass(string login, string password)
        {
            if (login == this.login && password == this.password)
                return true;
            return false;
        }
        
        
    }
}