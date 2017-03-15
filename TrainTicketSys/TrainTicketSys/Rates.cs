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
        private int typeID; private string description;

        public Rates ()
        {
            this.typeID = 0;
            this.description = "Unknown";
        }
        public Rates (int typeID, string description)
        {
            setTypeID(typeID); setDescription(description);
        }

        // TypeID
        public void setTypeID (int typeID)
        {
            this.typeID = typeID;
        }
        public int getTypeID ()
        {
            return this.typeID;
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

        // Method To Retrieve Next typeID
        public static int nextTypeID ()
        {
            int nextTypeID;
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string strSQL = "SELECT MAX(typeID) FROM Rates";

            OracleCommand cmd = new OracleCommand(strSQL, con);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0))
                nextTypeID = 1;
            else
                nextTypeID = Convert.ToInt32(dr.GetValue(0)) + 1;

            con.Close();
            return nextTypeID;
        }

        public void createRate()
        {
            // Connect to DB
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            // Define SQL Query
            string strSQL =
                "INSERT INTO Rates VALUES ("
                + this.typeID + ",'"
                + this.description + "')";

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
