using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogibForm
{
    internal class Customer
    {
        private int AccountID;
        private string Forename;
        private string Surname;
        private string EmailAddress;
        private string Password;
        private decimal TotalStorageUsed;
        private decimal TotalStorage;

        public Customer()
        {
            this.AccountID = 0;
            this.Forename = "";
            this.Surname = "";
            this.EmailAddress = "";
            this.Password = "";
            this.TotalStorageUsed = 0.00m;
            this.TotalStorage = 2000.00m;
        }
        public Customer(int accountID, string forename, string surname, string emailAddress, string password, decimal totalStorageUsed, decimal totalStorage)
        {
            AccountID = accountID;
            Forename = forename;
            Surname = surname;
            EmailAddress = emailAddress;
            Password = password;
            TotalStorageUsed = totalStorageUsed;
            TotalStorage = totalStorage;
        }

        public int getAccountID()
        {
            return this.AccountID;
        }
        public string getForename()
        {
            return this.Forename;
        }
        public string getSurname()
        {
            return this.Surname;
        }
        public string getEmailAddress()
        {
            return this.EmailAddress;
        }
        public string getPassword()
        {
            return this.Password;
        }
        public decimal getTotalStorageUsed()
        {
            return this.TotalStorageUsed;
        }
        public decimal getTotalStorage()
        {
            return this.TotalStorage;
        }

        public void setAccountID(int accountID)
        {
            this.AccountID = accountID;
        }
        public void setForename(string forename)
        {
            this.Forename = forename;
        }
        public void setSurname(string surname)
        {
            this.Surname = surname;
        }
        public void setEmailAddress(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }
        public void setPassword(string password)
        {
            this.Password = password;
        }
        public void setTotalStorageUsed(decimal totalStorageUsed)
        {
            this.TotalStorageUsed = totalStorageUsed;
        }
        public void setTotalStorage(decimal totalStorage)
        {
            this.TotalStorage = totalStorage;
        }

        public void addCustomer()
        {
            OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb);

            conn.Open();

            String sqlQuery = "INSERT INTO CustomerAccount VALUES (" +
                this.AccountID + ", '" +
                this.Forename + "', '" +
                this.Surname + "', '" +
                this.EmailAddress + "', '" +
                this.Password + "', '" +
                this.TotalStorageUsed + "', '" +
                this.TotalStorage + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void UpdateAccount()
        {
            OracleConnection conn = new OracleConnection();

            conn.Open();

            String updateAccountSQL = "UPDATE CustomerAccount SET " +
            "CustomerID = '" + this.AccountID + "', " + 
            "Forename = '" + this.Forename + "', " + 
            "Surname = '" + this.Surname + "', " + 
            "EmailAddress = '" + this.EmailAddress + "', " + 
            "Password = '" + this.Password + "', " + 
            "TotalStorageUsed = '" + this.TotalStorageUsed + "', " + 
            "TotalStorage = '" + this.TotalStorage + "' " + 
            "WHERE CustomerID = " + this.AccountID;

            OracleCommand cmd = new OracleCommand(updateAccountSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void removeAccount()
        {
            OracleConnection conn = new OracleConnection();

            conn.Open();

            String removeAccountSQL = "DELETE FROM CustomerAccounts WHERE CustomerID = " + this.AccountID;

            OracleCommand cmd = new OracleCommand(removeAccountSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet findAccount(String AccountName)
        {
            OracleConnection conn = new OracleConnection();

            conn.Open();

            String findAccountSQL = "SELECT * FROM CustomerAccount " +
            "WHERE Forename LIKE '%" + AccountName + "%' ORDER BY CustomerID";

            OracleCommand cmd = new OracleCommand(findAccountSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "CustomerAccount");

            conn.Close();

            return ds;
        }

        public static DataSet getAllAccounts()
        {
            OracleConnection conn = new OracleConnection();

            conn.Open();

            String allAccountsSQL = "SELECT * FROM CustomerAccount ORDER BY CustomerID";

            OracleCommand cmd = new OracleCommand(allAccountsSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "CustomerAccount");

            conn.Close();

            return ds;
        }
        public static DataSet getAccount(String accountName)
        {
            OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb);

            conn.Open();

            String userAccountSQL = "SELECT * FROM CustomerAccount " +
            "WHERE LIKE '%" + accountName + "%'";

            OracleCommand cmd = new OracleCommand(userAccountSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "CustomerAccount");

            conn.Close();

            return ds;
        }
        public static int getNextAccountID()
        {
            OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb);

            conn.Open();

            String sqlQuery = "SELECT MAX(CustomerID) FROM CustomerAccount";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            int nextID;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextID = 1;
            }
            else
            {
                nextID = dr.GetInt32(0) + 1;
            }

            conn.Close();

            return nextID;
        }
    }
}
