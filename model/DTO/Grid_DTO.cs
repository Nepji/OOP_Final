using System.Collections.Generic;

namespace OOP_lab3.model.DTO
{
    public class Grid_DTO
    {
            protected const int BorderSize = 25;
            public int PathWaySize { get; protected set; }
            protected bool[,] GameArea;
            
            public int[] _currentLastPosition { get; protected set; }
    }
}