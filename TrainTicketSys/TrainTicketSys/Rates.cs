using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketSys
{
    class Rates
    {
        private static OracleConnection con;
        private int typeID; private string description;

        public Rates ()
        {
            description = "Unknown";
        }
        public Rates (int typeID, string description)
        {

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
            int typeID;
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            String strSQL = "SELECT MAX(typeID) FROM Rates";

            OracleCommand cmd = new OracleCommand(strSQL, con);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0))
                typeID = 1;
            else
                typeID = Convert.ToInt32(dr.GetValue(0)) + 1;

            con.Close();
            return typeID;
        }
    }
}
