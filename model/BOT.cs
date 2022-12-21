using System;
using System.Threading;
using OOP_lab3.model.Enum;

namespace OOP_lab3.model
{
    public class BOT
    {
        public int[] curentposition { get; private set; }
        private int[] priviosposition;
        public Grid gameArea { get; }

        private MovementPosition_ENUM MovementPositionEnum = new MovementPosition_ENUM();

        public BOT(Grid gameArea, int[] curentposition)
        {
            this.curentposition = curentposition;
            this.gameArea = gameArea;
        }

        public Enum.MovementDirection WayToGo()
        {
            MovementDirection NextStep;
            Random rand = new Random();
            do
            { 
                NextStep = (Enum.MovementDirection) rand.Next(1,System.Enum.GetNames(typeof(Enum.MovementDirection)).Length+1);
            } while (!GoodWay(NextStep));
            Thread.Sleep(1000);
            return NextStep;
        }

        public void UpdatePosition(int[] curentposition)
        {
            priviosposition = new[] { this.curentposition[0], this.curentposition[1] };
            this.curentposition = new[] { curentposition[0], curentposition[1] };
        }
        
        bool GoodWay(Enum.MovementDirection NextStep)
        {
            int[] Position = MovementPositionEnum.Position(NextStep, curentposition);
            if(gameArea.NewGameArea()[Position[0],Position[1]]) 
                return true;
            return false;
          
        }
        
        
    }
}