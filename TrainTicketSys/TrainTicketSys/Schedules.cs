using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Schedules ()
        {
            this.scheduleID = 0; this.routeID = 0;
            this.numCarriages = 0; this.departTime = "00:00"; this.arrivalTime = "00:00";
        }

        public Schedules (int scheduleID, int routeID, int numCarriages, string departTime, string arrivalTime)
        {
            
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
    }
}
