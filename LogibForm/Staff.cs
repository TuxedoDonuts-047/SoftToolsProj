using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibForm
{
    internal class Staff
    {
        private int StaffID;
        private string Forename;
        private string Surname;
        private string EmailAddress;
        private string Password;

        public Staff()
        {
            this.StaffID = 0;
            this.Forename = "";
            this.Surname = "";
            this.EmailAddress = "";
            this.Password = "";
        }
        public Staff(int staffID, string forename, string surname, string emailAddress, string password)
        {
            StaffID = staffID;
            Forename = forename;
            Surname = surname;
            EmailAddress = emailAddress;
            Password = password;
        }

        public int getStaffID()
        {
            return this.StaffID;
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

        public void setStaffID(int staffID)
        {
            this.StaffID = staffID;
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

        public void addStaff()
        {
            OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb);

            conn.Open();

            String sqlQuery = "INSERT INTO CustomerAccount VALUES (" +
                this.StaffID + ", '" +
                this.Forename + "', '" +
                this.Surname + "', '" +
                this.EmailAddress + "', '" +
                this.Password + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void UpdateAccount()
        {
            OracleConnection conn = new OracleConnection();

            conn.Open();

            String updateAccountSQL = "UPDATE CustomerAccount SET " +
            "StaffID = '" + this.StaffID + "', " +
            "Forename = '" + this.Forename + "', " +
            "Surname = '" + this.Surname + "', " +
            "EmailAddress = '" + this.EmailAddress + "', " +
            "Password = '" + this.Password + "' " +
            "WHERE StaffID = " + this.StaffID;

            OracleCommand cmd = new OracleCommand(updateAccountSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void removeAccount()
        {
            OracleConnection conn = new OracleConnection();

            conn.Open();

            String removeAccountSQL = "DELETE FROM StaffAccount WHERE StaffID = " + this.StaffID;

            OracleCommand cmd = new OracleCommand(removeAccountSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet findAccount(String AccountName)
        {
            OracleConnection conn = new OracleConnection();

            conn.Open();

            String findAccountSQL = "SELECT * FROM StaffAccount " +
            "WHERE Forename LIKE '%" + AccountName + "%' ORDER BY StaffID";

            OracleCommand cmd = new OracleCommand(findAccountSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "StaffAccount");

            conn.Close();

            return ds;
        }

        public static DataSet getAllAccounts()
        {
            OracleConnection conn = new OracleConnection();

            conn.Open();

            String allAccountsSQL = "SELECT * FROM StaffAccount ORDER BY StaffID";

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

            String userAccountSQL = "SELECT * FROM StaffAccount " +
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

            String sqlQuery = "SELECT MAX(StaffID) FROM StaffAccount";

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
