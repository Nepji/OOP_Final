using System.Collections.Generic;

namespace OOP_lab3.model.DTO
{
    public class Account_DTO
    {
        protected string login;
        protected string password;
        public string nickname { get; protected set;}
        public int GamesCount { get; protected set; }
        
    }
}