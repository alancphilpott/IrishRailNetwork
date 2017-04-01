using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace TrainTicketSys
{
    class Sales
    {
        private static OracleConnection con;

        private int saleID;
        private int scheduleID;
        private string typeCode;
        private decimal totalCost;
        private string saleDate;

        public Sales ()
        {
            this.saleID = 0; this.scheduleID = 0; this.typeCode = "UN";
            this.totalCost = 0; this.saleDate = "00:00:0000";
        }

        public Sales (int saleID, int scheduleID, string typeCode, decimal totalCost, string saleDate)
        {
            setSaleID(saleID); setScheduleID(scheduleID); setTypeCode(typeCode); setTotalCost(totalCost); setSaleDate(saleDate);
        }

        // Accessors and Mutators

        // Sale ID
        public void setSaleID (int saleID)
        {
            this.saleID = saleID;
        }
        public int getSaleID ()
        {
            return this.saleID;
        }

        // Schedule ID
        public void setScheduleID (int scheduleID)
        {
            this.scheduleID = scheduleID;
        }
        public int getScheduleID ()
        {
            return this.scheduleID;
        }

        // Type Code
        public void setTypeCode (string typeCode)
        {
            this.typeCode = typeCode;
        }
        public string getTypeCode ()
        {
            return this.typeCode;
        }

        // Total Cost
        public void setTotalCost (decimal totalCost)
        {
            this.totalCost = totalCost;
        }
        public decimal getTotalCost ()
        {
            return this.totalCost;
        }

        // Sale Date
        public void setSaleDate (string saleDate)
        {
            this.saleDate = saleDate;
        }
        public string getSaleDate ()
        {
            return this.saleDate;
        }

        // Method To Retrieve the Next Route ID
        public static int nextSaleID ()
        {
            int nextSaleID;
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            String strSQL = "SELECT MAX(saleID) FROM Sales";

            OracleCommand cmd = new OracleCommand(strSQL, con);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0))
                nextSaleID = 1;
            else
                nextSaleID = Convert.ToInt32(dr.GetValue(0)) + 1;

            con.Close();
            return nextSaleID;
        }

        public void createSale ()
        {
            // Connect to DB
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            // Define SQL Query
            string strSQL =
                "INSERT INTO Sales VALUES ("
                + this.saleID + ","
                + this.scheduleID + ",'"
                + this.typeCode + "',"
                + this.totalCost + ",'"
                + this.saleDate + "')";

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
