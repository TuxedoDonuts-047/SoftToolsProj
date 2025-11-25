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

        public Inventory(int id, string name, string genre, string descp,
                         decimal storage, decimal price, int inventory)
        {
            GameID = id;
            GameName = name;
            GameGenre = genre;
            GameDescription = descp;
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

        public bool updateGame(OracleConnection conn, OracleTransaction transaction)
        {
            string updateSql = @"UPDATE VideoGames 
                         SET GAMENAME = :name, 
                             GAMEGENRE = :genre, 
                             GAMEDESCRIPTION = :description, 
                             GAMESTORAGE = :storage, 
                             GAMEBUYPRICE = :price, 
                             GAMEINVENTORY = :inventory
                         WHERE GAMEID = :id";

            try
            {
                using (OracleCommand cmd = new OracleCommand(updateSql, conn))
                {
                    cmd.Transaction = transaction;
                    cmd.BindByName = true;

                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = this.GameName ?? "";
                    cmd.Parameters.Add("genre", OracleDbType.Varchar2).Value = this.GameGenre ?? "";
                    cmd.Parameters.Add("description", OracleDbType.Varchar2).Value = this.GameDescription ?? "";
                    cmd.Parameters.Add("storage", OracleDbType.Decimal).Value = this.GameStorage;
                    cmd.Parameters.Add("price", OracleDbType.Decimal).Value = this.GameBuyPrice;
                    cmd.Parameters.Add("inventory", OracleDbType.Int32).Value = this.GameInventory;
                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = this.GameID;

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        Console.WriteLine($"Warning: no row updated for GameID {this.GameID}");
                    }
                    else
                    {
                        Console.WriteLine($"Updated GameID {this.GameID}, rows affected: {rowsAffected}");
                    }

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating GameID {this.GameID}: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
    }
}
