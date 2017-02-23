using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace TrainTicketSys
{
    class Routes
    {
        private static OracleConnection con;

        // Class Attributes
        private int routeID;
        private string departStation;
        private string arrivalStation;
        private decimal distance;
        private char status;

        public Routes ()
        {
            this.routeID = 0; this.departStation = "";
            this.arrivalStation = ""; this.distance = 0;
            this.status = 'C';
        }

        public Routes (int routeID, string departStation, string arrivalStation, decimal distance, char status)
        {

        }

        // Setter and Getter Methods for Variables
        public void setRouteID (int routeID)
        {
            this.routeID = routeID;
        }
        public int getRouteID ()
        {
            return this.routeID;
        }

        public void setDepartStation (string departStation)
        {
            this.departStation = departStation;
        }
        public string getDepartStation ()
        {
            return this.departStation;
        }

        public void setArrivalStation (string arrivalStation)
        {
            this.arrivalStation = arrivalStation;
        }
        public string getArrivalStation ()
        {
            return this.arrivalStation;
        }

        public void setDistance (decimal distance)
        {
            this.distance = distance;
        }
        public decimal getDistance ()
        {
            return this.distance;
        }

        public void setStatus (char status)
        {
            this.status = status;
        }
        public char getStatus ()
        {
            return this.status;
        }

        public static int nextRouteID()
        {
            int nextRouteID;
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            String strSQL = "SELECT MAX(routeID) FROM Routes";

            OracleCommand cmd = new OracleCommand(strSQL, con);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0))
                nextRouteID = 1;
            else
                nextRouteID = Convert.ToInt32(dr.GetValue(0)) + 1;

            con.Close();
            return nextRouteID;
        }
    }
}
