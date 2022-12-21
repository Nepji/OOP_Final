using System;
using System.Collections.Generic;
using OOP_lab3.model.Enum;

namespace OOP_lab3.model
{
    public class Grid : DTO.Grid_DTO
    {
        public int _defaultPosition { get; }
        

        private Random rand = new Random();
        private MovementPosition_ENUM EnumPosition = new MovementPosition_ENUM();
        
        
        public Grid()
        {
            PathWaySize = rand.Next(15,20);
            _defaultPosition = BorderSize/2;
            _currentLastPosition = new int[2] { _defaultPosition, _defaultPosition };
            GameArea = new bool[BorderSize, BorderSize];
            
            ClearArea();
            GeneratePath();
        }
        
        
        void ClearArea()
        {
            for(int i=0;i<BorderSize;i++)
                for (int j = 0; j < BorderSize; j++)
                    GameArea[i, j] = false;
        }

        void GeneratePath()
        {
            Enum.MovementDirection NextStep;
            GameArea[_defaultPosition, _defaultPosition] = true;

            for (int i = 0; i < PathWaySize; i++)
            {
                do
                {
                    NextStep = (MovementDirection) rand.Next(1,System.Enum.GetNames(typeof(MovementDirection)).Length);
                } while (!GoodWay(NextStep));
                
                _currentLastPosition = EnumPosition.Position(NextStep, _currentLastPosition);
                GameArea[_currentLastPosition[0], _currentLastPosition[1]] = true;
            }
        }
        
        
        bool GoodWay(Enum.MovementDirection NextStep)
        {
            try
            {
                int[] Position = EnumPosition.Position(NextStep, _currentLastPosition);
                if(GameArea[Position[0],Position[1]]) return false;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool[,] NewGameArea()
        {
            return GameArea;
        }
    }
}