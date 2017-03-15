using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTicketSys
{
    class Schedules
    {
        private static OracleConnection con;

        // Class Attributes
        private int scheduleID;
        private int routeID;
        private int numCarriages;
        private string departTime;
        private string arrivalTime;
        private char status;

        public Schedules ()
        {
            this.scheduleID = 0; this.routeID = 0;
            this.numCarriages = 0; this.departTime = "00:00:00"; this.arrivalTime = "00:00:00";
        }

        public Schedules (int scheduleID, int routeID, int numCarriages, string departTime, string arrivalTime)
        {
            setScheduleID(scheduleID); setRouteID(routeID); setNumCarriages(numCarriages);
            setDepartTime(departTime); setArrivalTime(arrivalTime);
        }

        // Setters and Getters
        public void setScheduleID (int scheduleID)
        {
            this.scheduleID = scheduleID;
        }
        public int getScheduleID ()
        {
            return this.scheduleID;
        }

        public void setRouteID (int routeID)
        {
            this.routeID = routeID;
        }
        public int getRouteID ()
        {
            return this.routeID;
        }

        public void setNumCarriages (int numCarriages)
        {
            this.numCarriages = numCarriages;
        }
        public int getNumCarriages ()
        {
            return this.numCarriages;
        }

        public void setDepartTime (string departTime)
        {
            this.departTime = departTime;
        }
        public string getDepartTime ()
        {
            return this.departTime;
        }

        public void setArrivalTime (string arrivalTime)
        {
            this.arrivalTime = arrivalTime;
        }
        public string getArrivalTime ()
        {
            return this.arrivalTime;
        }

        // Method To Retrieve the Next Schedule ID
        public static int nextScheduleID()
        {
            int nextScheduleID;
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            String strSQL = "SELECT MAX(scheduleID) FROM Schedules";

            OracleCommand cmd = new OracleCommand(strSQL, con);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0))
                nextScheduleID = 1;
            else
                nextScheduleID = Convert.ToInt32(dr.GetValue(0)) + 1;

            con.Close();
            return nextScheduleID;
        }

        public void createSchedule ()
        {
            // Connect to DB
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            // Define SQL Query
            string strSQL =
                "INSERT INTO Schedules (scheduleID, routeID, numCarriages, depTime, arrTime) VALUES ("
                + this.scheduleID + ","
                + this.routeID + ","
                + this.numCarriages + ",'"
                + this.departTime + "','"
                + this.arrivalTime + "')";

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

        public static DataSet getRouteSchedules(DataSet DS, int routeID)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string SQL = "SELECT * FROM Schedules WHERE routeID = " + routeID + "";
            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);
            DA.Fill(DS, "Schedules");

            con.Close();

            return DS;
        }
    }
}
