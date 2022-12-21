namespace OOP_lab3.model
{
    public class Player
        {
            protected int[] basicposition;
            
            public int[] curentposition { get; private set; }

            private MovementPosition_ENUM EnumPosition = new MovementPosition_ENUM();

            public Player(int[] BasicPosition)
            {
                basicposition = BasicPosition;
                curentposition = new[] { basicposition[0], basicposition[1] };
            }

            public void PlayerMoved(Enum.MovementDirection NextStep)
            {
                curentposition = EnumPosition.Position(NextStep, curentposition);
            }
            
            public void ToDefaultPosition()
            {
                curentposition = new[] { basicposition[0], basicposition[1] };
            }
        }

}