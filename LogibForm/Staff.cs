using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace LogibForm
{
    internal class Staff
    {
        private int StaffID;
        private string Forename;
        private string Surname;
        private string Username;
        private string EmailAddress;
        private string Password;

        public Staff()
        {
            this.StaffID = 0;
            this.Forename = "";
            this.Surname = "";
            this.Username = "";
            this.EmailAddress = "";
            this.Password = "";
        }

        public Staff(int staffID, string forename, string surname, string username,
                     string emailAddress, string password)
        {
            this.StaffID = staffID;
            this.Forename = forename;
            this.Surname = surname;
            this.Username = username;
            this.EmailAddress = emailAddress;
            this.Password = password;
        }

        public int getStaffID() => this.StaffID;
        public string getForename() => this.Forename;
        public string getSurname() => this.Surname;
        public string getUsername() => this.Username;
        public string getEmailAddress() => this.EmailAddress;
        public string getPassword() => this.Password;

        public void setStaffID(int id) => this.StaffID = id;
        public void setForename(string f) => this.Forename = f;
        public void setSurname(string s) => this.Surname = s;
        public void setUsername(string u) => this.Username = u;
        public void setEmailAddress(string e) => this.EmailAddress = e;
        public void setPassword(string p) => this.Password = p;

        public void addStaff()
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql =
                    "INSERT INTO StaffAccount " +
                    "(StaffID, Forename, Surname, Username, EmailAddress, StaffPassword) " +
                    "VALUES (:id, :fn, :sn, :un, :email, :pwd)";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(":id", OracleDbType.Int32).Value = StaffID;
                    cmd.Parameters.Add(":fn", OracleDbType.Varchar2).Value = Forename;
                    cmd.Parameters.Add(":sn", OracleDbType.Varchar2).Value = Surname;
                    cmd.Parameters.Add(":un", OracleDbType.Varchar2).Value = Username;
                    cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = EmailAddress;
                    cmd.Parameters.Add(":pwd", OracleDbType.Varchar2).Value = Password;

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void UpdateAccount()
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql =
                    "UPDATE StaffAccount SET " +
                    "Forename = :fn, Surname = :sn, Username = :un, " +
                    "EmailAddress = :email, StaffPassword = :pwd " +
                    "WHERE StaffID = :id";

                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(":fn", Forename);
                cmd.Parameters.Add(":sn", Surname);
                cmd.Parameters.Add(":un", Username);
                cmd.Parameters.Add(":email", EmailAddress);
                cmd.Parameters.Add(":pwd", Password);
                cmd.Parameters.Add(":id", StaffID);

                cmd.ExecuteNonQuery();
            }
        }


        public void removeAccount()
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql = "DELETE FROM StaffAccount WHERE StaffID = :id";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":id", StaffID);

                cmd.ExecuteNonQuery();
            }
        }

        public static DataSet findAccount(string name)
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql =
                    "SELECT * FROM StaffAccount " +
                    "WHERE Forename LIKE :name ORDER BY StaffID";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":name", "%" + name + "%");

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "StaffAccount");

                return ds;
            }
        }

        public static DataSet getAllAccounts()
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql = "SELECT * FROM StaffAccount ORDER BY StaffID";

                OracleCommand cmd = new OracleCommand(sql, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "StaffAccount");

                return ds;
            }
        }

        public static DataSet getAccount(string username)
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql =
                    "SELECT * FROM StaffAccount WHERE Username LIKE :user";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":user", "%" + username + "%");

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "StaffAccount");

                return ds;
            }
        }

        public static int getNextStaffID()
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string sql = "SELECT MAX(StaffID) FROM StaffAccount";

                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                int nextID = 1;

                if (dr.Read() && !dr.IsDBNull(0))
                {
                    nextID = dr.GetInt32(0) + 1;
                }

                return nextID;
            }
        }
    }
}
