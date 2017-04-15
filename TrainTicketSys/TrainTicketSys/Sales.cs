using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace TrainTicketSys
{
    class Sales
    {
        private static OracleConnection con;
      
        // Class Attributes
        private int saleID;
        private int scheduleID;
        private string typeCode;
        private decimal totalCost;
        private string saleDate;

        // No Argument Constructor
        public Sales ()
        {
            this.saleID = 0; this.scheduleID = 0; this.typeCode = "UN";
            this.totalCost = 0; this.saleDate = "00:00:0000";
        }

        // Argument Constructor
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
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        // Method To Create A Sale
        public void createSale ()
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

        // Method To Get Sales Analysis (Amount and Month)
        public static DataSet getSalesAnalysis (DataSet DS)
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

            string SQL = @"SELECT 
                                TO_CHAR(TO_DATE(EXTRACT(MONTH FROM TO_DATE(SaleDate,'dd/mm/yy')), 'MM'), 'MONTH') AS TheMonth, SUM(TotalCost) AS TotalCost
                           FROM 
                                Sales
                           GROUP BY 
                                TO_CHAR(TO_DATE(EXTRACT(MONTH FROM TO_DATE(SaleDate,'dd/mm/yy')), 'MM'), 'MONTH')";
            OracleCommand cmd = new OracleCommand(SQL, con);
            OracleDataAdapter DA = new OracleDataAdapter(cmd);

            try
            {
                DA.Fill(DS, "Sales");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return DS;
        }

        // Method To Get Ticket Analysis (Amount and Type)
        public static DataSet getTicketAnalysis (DataSet DS)
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

            string SQL = @"SELECT 
                                R.description AS CODEDESC, COUNT(S.typeCode) AS NUMSALES
                           FROM 
                                Rates R, Sales S
                           WHERE 
                                R.typeCode = S.typeCode
                           GROUP BY 
                                R.description, S.typeCode";

            OracleCommand cmd = new OracleCommand(SQL, con);
            OracleDataAdapter DA = new OracleDataAdapter(cmd);

            try
            {
                DA.Fill(DS, "Sales");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return DS;
        }
    }
}