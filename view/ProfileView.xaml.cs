using System.Windows.Controls;
using OOP_lab3.model.Static;

namespace OOP_lab3.view
{
    public partial class ProfileView : UserControl
    {
        public ProfileView()
        {
            InitializeComponent();
            if (LogIN._logINed)
            {
                NickName.Content = LogIN.authAccount.nickname;
                GamesCount.Content = LogIN.authAccount.GamesCount.ToString();
                History();
            }
            
        }

        private void History()
        {
            if (LogIN.authAccount.GamesCount >= 1)
                Label_1.Content = LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 1].gameID +
                                  "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 1]
                                      .maxlevelofgame + "  |  " + LogIN.authAccount
                                      .historyNotes[LogIN.authAccount.historyNotes.Count - 1].countoflives;
            if (LogIN.authAccount.GamesCount >= 2)
                Label_1.Content = LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 2].gameID +
                                  "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 2]
                                      .maxlevelofgame + "  |  " + LogIN.authAccount
                                      .historyNotes[LogIN.authAccount.historyNotes.Count - 2].countoflives;
            if (LogIN.authAccount.GamesCount >= 3)
                Label_1.Content = LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 3].gameID +
                                  "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 3]
                                      .maxlevelofgame + "  |  " + LogIN.authAccount
                                      .historyNotes[LogIN.authAccount.historyNotes.Count - 3].countoflives;
            if (LogIN.authAccount.GamesCount >= 4)
                Label_1.Content = LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 4].gameID +
                                  "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 4]
                                      .maxlevelofgame + "  |  " + LogIN.authAccount
                                      .historyNotes[LogIN.authAccount.historyNotes.Count - 4].countoflives;
            if (LogIN.authAccount.GamesCount >= 5)
                Label_1.Content = LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 5].gameID +
                                  "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 5]
                                      .maxlevelofgame + "  |  " + LogIN.authAccount
                                      .historyNotes[LogIN.authAccount.historyNotes.Count - 5].countoflives;
            if (LogIN.authAccount.GamesCount >= 6)
                Label_1.Content = LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 6].gameID +
                                  "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 6]
                                      .maxlevelofgame + "  |  " + LogIN.authAccount
                                      .historyNotes[LogIN.authAccount.historyNotes.Count - 6].countoflives;
            if (LogIN.authAccount.GamesCount >= 7)
                Label_1.Content = LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 7].gameID +
                                  "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 7]
                                      .maxlevelofgame + "  |  " + LogIN.authAccount
                                      .historyNotes[LogIN.authAccount.historyNotes.Count - 7].countoflives;
            if (LogIN.authAccount.GamesCount >= 8)
                Label_1.Content = LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 8].gameID +
                                  "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 8]
                                      .maxlevelofgame + "  |  " + LogIN.authAccount
                                      .historyNotes[LogIN.authAccount.historyNotes.Count - 8].countoflives;
            if (LogIN.authAccount.GamesCount >= 9)
                Label_1.Content = LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 9].gameID +
                                  "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 9]
                                      .maxlevelofgame + "  |  " + LogIN.authAccount
                                      .historyNotes[LogIN.authAccount.historyNotes.Count - 9].countoflives;
            if (LogIN.authAccount.GamesCount >= 10)
                Label_1.Content = LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 10].gameID +
                                  "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - 10]
                                      .maxlevelofgame + "  |  " + LogIN.authAccount
                                      .historyNotes[LogIN.authAccount.historyNotes.Count - 10].countoflives;
        }
    }
}