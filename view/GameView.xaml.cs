using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using OOP_lab3.model;
using OOP_lab3.model.Enum;
using OOP_lab3.model.Static;


namespace OOP_lab3.view
{
    public partial class GameView : UserControl
    {
        private Account _account;
        private GameINFO GameInfo;
        
        public GameView()
        {
            InitializeComponent();
            if (!LogIN._logINed)
            {
                INFO.Content = "You need to Authorise first!";
                return;
            }
            GameInfo = new GameINFO(this);
            UpdateLives();
            ActorGrid.Focus();
        }

        private void Reset()
        {
            GameInfo.Reset();
            GameInfo.StartNewGame();
            BasicBackground(ActorGrid, GameInfo._game);
            UpdateLives();
        }
        public void UpdateLives()
        {
            INFO.Content = "";
            for (int i = 0; i < GameInfo.curentLives; i++)
                INFO.Content += "*";
        }

        public void OverLabel()
        {
            INFO.Content = "Game Over";
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(!GameInfo.gamestarted || GameInfo._game==null || GameInfo.gameover || !LogIN._logINed) return;
            switch (e.Key)
            {
                case Key.W:
                    GameInfo._game.ActorMoved(MovementDirection.Up);
                    break;
                
                case Key.S:
                    GameInfo._game.ActorMoved(MovementDirection.Down);
                    break;
                
                case Key.A:
                    GameInfo._game.ActorMoved(MovementDirection.Left);
                    break;
                
                case Key.D:
                    GameInfo._game.ActorMoved(MovementDirection.Right);
                    break;
            }
            BasicBackground(ActorGrid, GameInfo._game);
        }

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            if (!LogIN._logINed) return;
            if(GameInfo.gamestarted) return;
            Level.Content = "Level: "+ GameInfo.currentgamelevel;
            GameInfo.gamestarted = true;
            GameInfo.StartNewGame();
            BasicBackground(ActorGrid, GameInfo._game);
        }

        private void BasicBackground(Canvas State, Game game)
        {
            State.Children.RemoveRange(0,State.Children.Count);
            
            bool doneDrawingBackground = false;  
            int nextX = 0, nextY = 0;  
            int rowCounter = 0;  
            bool nextIsOdd = false;
            Rectangle rect;
            

            while (!doneDrawingBackground)
            {
                if ((nextX == 120 && nextY == 120))
                    rect = new Rectangle()
                    {
                        Width = 10,
                        Height = 10,
                        Fill = Brushes.Gold
                    };
                else if (game.gameArea.NewGameArea()[nextX/10,nextY/10])
                    rect = new Rectangle()
                        {
                            Width = 10,
                            Height = 10,
                            Fill = Brushes.Orange
                        };
                else
                    rect = new Rectangle()
                    {
                        Width = 10,
                        Height = 10,
                        Fill = nextIsOdd ? Brushes.Black : Brushes.White
                    };
                

                if(game.player.curentposition[0] == nextX/10 && game.player.curentposition[1] == nextY/10)
                    rect = new Rectangle()
                    {
                        Width = 10,
                        Height = 10,
                        Fill = Brushes.Red
                    };
                    

                State.Children.Add(rect);
                Canvas.SetTop(rect,nextY);
                Canvas.SetLeft(rect,nextX);
                nextIsOdd = !nextIsOdd;
                nextX += 10;
                if (nextX >= 250)
                {
                    nextX = 0;
                    nextY += 10;
                    rowCounter++;
                    nextIsOdd = (rowCounter % 2 != 0);
                }

                if (nextY >= 250)
                {
                    doneDrawingBackground = true;
                }
            }
        }
    }
}