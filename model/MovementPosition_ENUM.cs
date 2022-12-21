using OOP_lab3.model.Enum;

namespace OOP_lab3.model
{
    public class MovementPosition_ENUM
    {
        public int[] Position(Enum.MovementDirection NextStep, int[] _currentPosition)
        {
            int[] Position = {_currentPosition[0],_currentPosition[1]};
            switch (NextStep)
            {
                case MovementDirection.Up:
                    Position[1]--;
                    break;
                
                case MovementDirection.Down:
                    Position[1]++;
                    break;
                
                case MovementDirection.Left:
                    Position[0]--;
                    break;
                
                case MovementDirection.Right:
                    Position[0]++;
                    break;
            }

            return Position;
        }
    }
}