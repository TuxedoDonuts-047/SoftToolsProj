using LogibForm;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LogibForm
{
    public class Inventory
    {
       
        private int GameID;
        private string GameName;
        private string GameGenre;
        private string GameDescription;
        private decimal GameBuyPrice;
        private decimal GameStorage;
        private int GameInventory;


        public Inventory()
        {
            GameID = 0;
            GameName = "";
            GameGenre = "";
            GameDescription = "";
            GameBuyPrice = 0;
            GameStorage = 0;
            GameInventory = 0;
        }

        public Inventory(int id, string name, string genre, string desc,
                         decimal storage, decimal price, int inventory)
        {
            GameID = id;
            GameName = name;
            GameGenre = genre;
            GameDescription = desc;
            GameStorage = storage;
            GameBuyPrice = price;
            GameInventory = inventory;
        }

   
        public int getGameID() { return GameID; }
        public string getGameName() { return GameName; }
        public string getGameGenre() { return GameGenre; }
        public string getGameDescription() { return GameDescription; }
        public decimal getGameStorage() { return GameStorage; }
        public decimal getGameBuyPrice() { return GameBuyPrice; }
        public int getGameInventory() { return GameInventory; }

        public void setGameID(int id) { GameID = id; }
        public void setGameName(string name) { GameName = name; }
        public void setGameGenre(string genre) { GameGenre = genre; }
        public void setGameDescription(string desc) { GameDescription = desc; }
        public void setGameStorage(decimal storage) { GameStorage = storage; }
        public void setGameBuyPrice(decimal price) { GameBuyPrice = price; }
        public void setGameInventory(int inv) { GameInventory = inv; }

        public void insertGame()
        {
            string sql = @"INSERT INTO VideoGames 
                           (GameID, GameName, GameDescription, GameGenre, 
                            GameStorage, GameBuyPrice, GameInventory)
                           VALUES 
                           (:id, :name, :desc, :genre, :storage, :price, :inventory)";

            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            using (OracleCommand cmd = new OracleCommand(sql, conn))
            {
                cmd.Parameters.Add(":id", GameID);
                cmd.Parameters.Add(":name", GameName);
                cmd.Parameters.Add(":desc", GameDescription);
                cmd.Parameters.Add(":genre", GameGenre);
                cmd.Parameters.Add(":storage", GameStorage);
                cmd.Parameters.Add(":price", GameBuyPrice);
                cmd.Parameters.Add(":inventory", GameInventory);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Game successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Error: " + ex.Message, "Error");
                }
            }
        }

        public void updateGame()
        {
            string sql = @"UPDATE VideoGames SET 
                           GameName = :name,
                           GameGenre = :genre,
                           GameDescription = :desc,
                           GameStorage = :storage,
                           GameBuyPrice = :price,
                           GameInventory = :inv
                           WHERE GameID = :id";

            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            using (OracleCommand cmd = new OracleCommand(sql, conn))
            {
                cmd.Parameters.Add(":name", GameName);
                cmd.Parameters.Add(":genre", GameGenre);
                cmd.Parameters.Add(":desc", GameDescription);
                cmd.Parameters.Add(":storage", GameStorage);
                cmd.Parameters.Add(":price", GameBuyPrice);
                cmd.Parameters.Add(":inv", GameInventory);
                cmd.Parameters.Add(":id", GameID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
            }
        }

        public static void reduceStock(int gameID, int qty)
        {
            string sql = @"UPDATE VideoGames 
                           SET GameInventory = GameInventory - :qty 
                           WHERE GameID = :id";

            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            using (OracleCommand cmd = new OracleCommand(sql, conn))
            {
                cmd.Parameters.Add(":qty", qty);
                cmd.Parameters.Add(":id", gameID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
            }
        }

        public static List<Inventory> getAllInventory()
        {
            List<Inventory> items = new List<Inventory>();

            string sql = @"SELECT GameID, GameName, GameDescription, GameGenre, 
                                  GameStorage, GameBuyPrice, GameInventory 
                           FROM VideoGames
                           ORDER BY GameID";

            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            using (OracleCommand cmd = new OracleCommand(sql, conn))
            {
                OracleDataReader reader = null;

                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        items.Add(new Inventory(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(3),
                            reader.GetString(2),
                            reader.GetDecimal(4),
                            reader.GetDecimal(5),
                            reader.GetInt32(6)
                        ));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inventory: " + ex.Message);
                }
                finally
                {
                    reader?.Close();
                }
            }

            return items;
        }

        public static bool hasStock(int gameID, int qty)
        {
            string sql = "SELECT GameInventory FROM VideoGames WHERE GameID = :id";

            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            using (OracleCommand cmd = new OracleCommand(sql, conn))
            {
                cmd.Parameters.Add(":id", gameID);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                        return false;

                    return Convert.ToInt32(result) >= qty;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
            }

            return false;
        }
    }
}
