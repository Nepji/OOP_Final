using OOP_lab3.view;

namespace OOP_lab3.model.Static
{
    public class GameINFO
    {
        public bool gamestarted { get; set; }
        public bool gameover { get; set; }
        public int currentgamelevel { get; set; }
        public int curentLives { get; set; }
        public Account account { get; set; }
        
        private GameView window;
        public Game _game { get; private set; }

        public GameINFO(GameView window)
        {
            LogIN logIn = LogIN.Initializate();
            this.account = logIn.authAccount;
            this.window = window;
            curentLives = 10;
            currentgamelevel = 0;
            gameover = false;
            gamestarted = false;
        }

        public void Reset()
        {
            gameover = false;
            curentLives = 10;
            currentgamelevel = 0;
        }

        public void StartNewGame()
        {
            gamestarted = true;
            _game = new Game(this);
        }

        public void CurrentGameOver()
        {
            currentgamelevel++;
            gamestarted = false;
            window.Button.Content = "Start";
        }

        public void GameOver()
        {
            gameover = true;
            gamestarted = false;
            account.addHistoryNote(this.curentLives, this.currentgamelevel);
            Reset();
            window.OverLabel();
        }

        public void RemoveLive()
        {
            curentLives--;
            window.UpdateLives();
            if (curentLives == 0)
                GameOver();
            
        }
    }
}