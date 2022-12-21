using System.Collections.Generic;
using OOP_lab3.model.Static;
using OOP_lab3.view;

namespace OOP_lab3.model.DTO
{
    public class Game_DTO
    {
        public Grid gameArea { get; protected set; }
        public Player player { get; protected set; }
        protected int currentLvl;
        protected GameINFO window;
        protected Account currentaccount;
    }
}