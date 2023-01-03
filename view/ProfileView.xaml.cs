using System.Windows.Controls;
using OOP_lab3.model.Static;

namespace OOP_lab3.view
{
    public partial class ProfileView : UserControl
    {
        private LogIN logIn = null;
        public ProfileView()
        {
            InitializeComponent();
            logIn = model.Static.LogIN.Initializate();
            if (logIn._logINed)
            {
                NickName.Content = logIn.authAccount.nickname;
                GamesCount.Content = logIn.authAccount.GamesCount.ToString();
                History();
            }

        }

        private void History()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (logIn.authAccount.GamesCount < i) break;
                Label labla = new Label();
                labla.Content =
                    logIn.authAccount.historyNotes[logIn.authAccount.historyNotes.Count - i].gameID +
                    "  |  " + logIn.authAccount.historyNotes[logIn.authAccount.historyNotes.Count - i]
                        .maxlevelofgame + "  |  " + logIn.authAccount
                        .historyNotes[logIn.authAccount.historyNotes.Count - i].countoflives;
                ;
                history.Children.Add(labla);
            }
        }
    }
}