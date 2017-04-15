using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System;

namespace TrainTicketSys
{
    class Rates
    {
        private static OracleConnection con;

        // Class Attributes
        private string typeCode;
        private string description;
        private decimal ratePerKM;

        // No Argument Constructor
        public Rates ()
        {
            this.typeCode = "UN";
            this.description = "Unknown";
        }

        // Argument Constructor
        public Rates (string typeCode, string description, decimal ratePerKM)
        {
            setTypeCode(typeCode); setDescription(description); setRatePerKM(ratePerKM);
        }

        // Setter and Getter Methods for Variables
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
            con = new OracleConnection(DBConnect.oradb);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        // Method To Create a Rate
        public void createRate()
        {
            // Connect to DB
            con = new OracleConnection(DBConnect.oradb);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Define SQL Query
            string strSQL =
                "INSERT INTO Rates VALUES (UPPER('"
                + this.typeCode + "'),UPPER('"
                + this.description + "'),"
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

        // Method to Get All Rates WITH Sort Order
        public static DataSet getRates(DataSet DS, String sortOrder)
        {
            con = new OracleConnection(DBConnect.oradb);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string SQL = "SELECT typeCode, description FROM Rates ORDER BY " + sortOrder;
            OracleCommand cmd = new OracleCommand(SQL, con);
            OracleDataAdapter DA = new OracleDataAdapter(cmd);
            DA.Fill(DS, "Rates");

            con.Close();

            return DS;
        }

        // Method To Get A Rate Relavent To TypeCode (NOT RETURNING)
        public void getRate (string typeCode)
        {
            con = new OracleConnection(DBConnect.oradb);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string SQL = "SELECT * FROM Rates WHERE typeCode = '" + typeCode + "'";
            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //intantiate instance variables
            this.typeCode = dr.GetString(0);
            this.description = dr.GetString(1);
            this.ratePerKM = dr.GetDecimal(2);

            con.Close();
        }

        // Method To Update A Station
        public static void updateRate(string typeCode, string description, decimal ratePerKM)
        {
            con = new OracleConnection(DBConnect.oradb);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string SQL = "UPDATE Rates SET description = UPPER('"
                + description + "'), ratePerKM = '"
                + ratePerKM + "' WHERE typeCode = '" + typeCode + "'";

            OracleCommand cmd = new OracleCommand(SQL, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
