using OOP_lab3.model.Static;
using OOP_lab3.view;

namespace OOP_lab3.model
{
    public class Game : DTO.Game_DTO
    {
        public Game(GameINFO window)
        {
            gameArea = new Grid();
            this.window = window;
            currentLvl = window.currentgamelevel;
            this.player = new Player(gameArea._currentLastPosition);
        }

        public Game(int currentLvl, GameINFO window) : this(window)
        {
            this.currentLvl = currentLvl;
        }

        void FinishGame()
        {
            window.CurrentGameOver();
            window.gamestarted = false;
        }

        bool EndGameRule()
        {
            int[] temp_defaultposition = new int[] { gameArea._defaultPosition, gameArea._defaultPosition };
            if (player.curentposition[0] == temp_defaultposition[0] && player.curentposition[1] == temp_defaultposition[1]) return true;
            return false;
        }
       

        public void ActorMoved(Enum.MovementDirection NextStep)
        {
            this.player.PlayerMoved(NextStep);
            if(!GoodMove())
            {
                player.ToDefaultPosition();
                window.RemoveLive();
            }
            if(EndGameRule()) FinishGame();
        }

        bool GoodMove()
        {
            int[] position = player.curentposition;
            bool[,] area = gameArea.NewGameArea();

            if (area[position[0], position[1]]) return true;
            return false;
        }

    }
}