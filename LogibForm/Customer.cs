using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace LogibForm
{
    internal class Customer
    {
        private int AccountID;
        private string Forename;
        private string Surname;    
        private string Username;
        private string EmailAddress;
        private string Password;
        private decimal TotalStorageUsed;
        private decimal TotalStorage;

        public Customer()
        {
            this.AccountID = 0;
            this.Forename = "";
            this.Surname = "";
            this.Username = "";
            this.EmailAddress = "";
            this.Password = "";
            this.TotalStorageUsed = 0.00m;
            this.TotalStorage = 2000.00m;
        }

        public Customer(int accountID, string forename, string username, string surname, string emailAddress,
                        string password, decimal totalStorageUsed, decimal totalStorage)
        {
            this.AccountID = accountID;
            this.Forename = forename;
            this.Surname = surname;
            this.Username = username;
            this.EmailAddress = emailAddress;
            this.Password = password;
            this.TotalStorageUsed = totalStorageUsed;
            this.TotalStorage = totalStorage;
        }

        public int getAccountID() => this.AccountID;
        public string getForename() => this.Forename;
        public string getSurname() => this.Surname;
        public string getUsername() => this.Username;
        public string getEmailAddress() => this.EmailAddress;
        public string getPassword() => this.Password;
        public decimal getTotalStorageUsed() => this.TotalStorageUsed;
        public decimal getTotalStorage() => this.TotalStorage;

        public void setAccountID(int id) => this.AccountID = id;
        public void setForename(string f) => this.Forename = f;
        public void setSurname(string s) => this.Surname = s;
        public void setUsername(string u) => this.Username = u;
        public void setEmailAddress(string email) => this.EmailAddress = email;
        public void setPassword(string p) => this.Password = p;
        public void setTotalStorageUsed(decimal used) => this.TotalStorageUsed = used;
        public void setTotalStorage(decimal t) => this.TotalStorage = t;

        public void addCustomer()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
                {
                    conn.Open();

                    string sqlQuery =
                        "INSERT INTO CustomerAccount " +
                        "(CustomerID, Forename, Surname, Username, EmailAddress, CustPassword, StorageUsed, AvailableStorage) " +
                        "VALUES (:id, :fn, :sn, :username, :email, :pwd, :used, :avail)";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = AccountID;
                        cmd.Parameters.Add(":fn", OracleDbType.Varchar2).Value = Forename;
                        cmd.Parameters.Add(":sn", OracleDbType.Varchar2).Value = Surname;
                        cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = Username;
                        cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = EmailAddress;
                        cmd.Parameters.Add(":pwd", OracleDbType.Varchar2).Value = Password;
                        cmd.Parameters.Add(":used", OracleDbType.Decimal).Value = TotalStorageUsed;
                        cmd.Parameters.Add(":avail", OracleDbType.Decimal).Value = TotalStorage;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void UpdateAccount()
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string updateSQL =
                    "UPDATE CustomerAccount SET " +
                    "Forename = :fn, " +
                    "Surname = :sn, " +
                    "EmailAddress = :email, " +
                    "Username = :user, " +
                    "CustPassword = :pwd, " +
                    "StorageUsed = :used, " +
                    "AvailableStorage = :avail " +
                    "WHERE CustomerID = :id";

                OracleCommand cmd = new OracleCommand(updateSQL, conn);

                cmd.Parameters.Add(":fn", Forename);
                cmd.Parameters.Add(":sn", Surname);
                cmd.Parameters.Add(":email", EmailAddress);
                cmd.Parameters.Add(":user", Username);
                cmd.Parameters.Add(":pwd", Password);
                cmd.Parameters.Add(":used", TotalStorageUsed);
                cmd.Parameters.Add(":avail", TotalStorage);
                cmd.Parameters.Add(":id", AccountID);

                cmd.ExecuteNonQuery();
            }
        }

        public void removeAccount()
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string deleteSQL = "DELETE FROM CustomerAccount WHERE CustomerID = :id";

                OracleCommand cmd = new OracleCommand(deleteSQL, conn);
                cmd.Parameters.Add(":id", AccountID);

                cmd.ExecuteNonQuery();
            }
        }

        public static DataSet findAccount(string name)
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql = "SELECT * FROM CustomerAccount WHERE Forename LIKE :name ORDER BY CustomerID";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":name", "%" + name + "%");

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "CustomerAccount");

                return ds;
            }
        }

        public static DataSet getAllAccounts()
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql = "SELECT * FROM CustomerAccount ORDER BY CustomerID";

                OracleCommand cmd = new OracleCommand(sql, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "CustomerAccount");

                return ds;
            }
        }

        public static DataSet getAccount(string username)
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql = "SELECT * FROM CustomerAccount WHERE Username LIKE :u";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":u", "%" + username + "%");

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "CustomerAccount");

                return ds;
            }
        }

        public static int getNextAccountID()
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql = "SELECT MAX(CustomerID) FROM CustomerAccount";

                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                int nextID = 1;

                if (dr.Read() && !dr.IsDBNull(0))
                    nextID = dr.GetInt32(0) + 1;

                return nextID;
            }
        }
    }
}
