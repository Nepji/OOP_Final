namespace OOP_lab3.model
{
    public class HistoryNote : DTO.HistoryNote_DTO
    {
        public HistoryNote(int countoflives, int maxlevelofgame, int GameID)
        {
            this.countoflives = countoflives;
            this.maxlevelofgame = maxlevelofgame;
            this.gameID = GameID;
        }
    }
}