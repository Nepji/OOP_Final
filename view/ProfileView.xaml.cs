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
            for (int i = 1; i <= 10; i++)
            {
                if (LogIN.authAccount.GamesCount < i) break;
                Label labla = new Label();
                labla.Content =
                    LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - i].gameID +
                    "  |  " + LogIN.authAccount.historyNotes[LogIN.authAccount.historyNotes.Count - i]
                        .maxlevelofgame + "  |  " + LogIN.authAccount
                        .historyNotes[LogIN.authAccount.historyNotes.Count - i].countoflives;
                ;
                history.Children.Add(labla);
            }
        }
    }
}