using System;

namespace LogibForm
{
    public class Inventory
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public string GameGenre { get; set; }
        public decimal GameStorage { get; set; }
        public decimal GameBuyPrice { get; set; }
        public int GameInventory { get; set; }

        public Inventory() { }

        public Inventory(int gameID, string gameName, string gameDescription,
                         string gameGenre, decimal gameStorage,
                         decimal gameBuyPrice, int gameInventory)
        {
            GameID = gameID;
            GameName = gameName;
            GameDescription = gameDescription;
            GameGenre = gameGenre;
            GameStorage = gameStorage;
            GameBuyPrice = gameBuyPrice;
            GameInventory = gameInventory;
        }

        public override string ToString()
        {
            return $"{GameID} - {GameName} ({GameGenre}) | Stock: {GameInventory} | Price: {GameBuyPrice:C}";
        }

        public Inventory Clone()
        {
            return new Inventory(GameID, GameName, GameDescription, GameGenre,
                                 GameStorage, GameBuyPrice, GameInventory);
        }
    }
}
