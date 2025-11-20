using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogibForm
{
    public static class Session
    {
        public static string LoggedInUser { get; set; }
        public static int LoggedInAccountID { get; set; }
        public static string LoggedInStaffUser { get; set; }
        public static int LoggedInStaffID { get; set; }

        public static void LoadCustomerSession(string email)
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string IDloginSQL = "SELECT * FROM CustomerAccount WHERE EmailAddress = :email";

                using (OracleCommand cmd = new OracleCommand(IDloginSQL, conn))
                {
                    cmd.Parameters.Add("email", email);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Session.LoggedInAccountID = Convert.ToInt32(reader["CustomerID"]);
                        }
                    }
                }
            }
        }
        public static void LoadStaffSession(string email)
        {
            using (OracleConnection conn = new OracleConnection(PrimalDirectDB.oradb))
            {
                conn.Open();

                string IDloginSQL = "SELECT * FROM StaffAccount WHERE EmailAddress = :email";

                using (OracleCommand cmd = new OracleCommand(IDloginSQL, conn))
                {
                    cmd.Parameters.Add("email", email);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Session.LoggedInAccountID = Convert.ToInt32(reader["StaffID"]);
                        }
                    }
                }
            }
        }

    }
}
