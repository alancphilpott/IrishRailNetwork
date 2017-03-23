using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;

namespace TrainTicketSys
{
    class Rates
    {
        private static OracleConnection con;

        private string typeCode;
        private string description;
        private decimal ratePerKM;

        public Rates ()
        {
            this.typeCode = "UN";
            this.description = "Unknown";
        }
        public Rates (string typeCode, string description, decimal ratePerKM)
        {
            setTypeCode(typeCode); setDescription(description); setRatePerKM(ratePerKM);
        }

        // TypeID
        public void setTypeCode (string typeCode)
        {
            this.typeCode = typeCode;
        }
        public string getTypeCode ()
        {
            return this.typeCode;
        }

        // Description
        public void setDescription (string description)
        {
            this.description = description;
        }
        public string getDescription ()
        {
            return this.description;
        }

        // Rate Per KM
        public void setRatePerKM (decimal ratePerKM)
        {
            this.ratePerKM = ratePerKM;
        }
        public decimal getRatePerKM ()
        {
            return this.ratePerKM;
        }

        // Method To Check If A TypeCode Already Exists
        public static Boolean alreadyExists (String typeCode)
        {
            Boolean valid = false;

            // Connect To DB
            con = new OracleConnection(DBConnect.oradb); con.Open();

            // Define SQL Query
            string strSQL =
                "SELECT * FROM Rates WHERE typeCode = '" + typeCode + "'";
            OracleCommand cmd = new OracleCommand(strSQL, con);
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                valid = true;

            //Close Database Connection
            con.Close();

            return valid;
        }

        public void createRate()
        {
            // Connect to DB
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            // Define SQL Query
            string strSQL =
                "INSERT INTO Rates VALUES ('"
                + this.typeCode + "','"
                + this.description + "',"
                + this.ratePerKM + ")";

            // Execute Command/Query
            OracleCommand cmd = new OracleCommand(strSQL, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close Database Connection
            con.Close();
        }
    }
}
