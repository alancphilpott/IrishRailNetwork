using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrainTicketSys
{
    class Routes
    {
        private static OracleConnection con;

        // Class Attributes
        private int routeID;
        private string departStation;
        private string arrivalStation;
        private double distance;
        private char status;

        public Routes ()
        {
            this.routeID = 0; this.departStation = "";
            this.arrivalStation = ""; this.distance = 0.00;
            this.status = 'C';
        }

        public Routes (int routeID, string departStation, string arrivalStation, double distance, char status)
        {
            setRouteID(routeID); setDepartStation(departStation);
            setArrivalStation(arrivalStation); setDistance(distance); setStatus(status);
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

        public void setDistance (double distance)
        {
            this.distance = distance;
        }
        public double getDistance ()
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

        // Method To Retrieve the Next Route ID
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

        // Method for Adding A Route to the Database
        public void createRoute ()
        {
            // Connect To DB
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            // Define SQL Query
            string strSQL =
                "INSERT INTO Routes VALUES ("
                + this.routeID + ",'"
                + this.departStation + "','"
                + this.arrivalStation + "',"
                + this.distance + ",'"
                + this.status + "')";

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

            // Close Database
            con.Close();
        }

        // Method To Populate DataGrid
        public static DataSet getRoutes (DataSet DS)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string SQL = "SELECT * FROM Routes ORDER BY routeID";

            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);
            DA.Fill(DS, "Routes");

            con.Close();

            return DS;
        }

        // Method To Populate DataGrid Relevant To A User Search
        public static DataSet getRoutes (DataSet DS, String txtKeyword)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string SQL = "SELECT * FROM Routes WHERE upper(DEPARTSTATION) LIKE '" + txtKeyword.ToUpper() + "%' ORDER BY routeID";

            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);
            DA.Fill(DS, "Routes");

            con.Close();

            return DS;
        }

        public static DataSet getActiveRoutes(DataSet DS, String sortOrder)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string SQL = "SELECT * FROM Routes WHERE status = 'A' ORDER BY " + sortOrder;

            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);
            DA.Fill(DS, "Routes");

            con.Close();

            return DS;
        }

        public static DataTable getARoute(int routeID)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string SQL = "SELECT * FROM Routes WHERE routeID = " + routeID + "";
            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            DA.Fill(DS, "aRoute");

            con.Close();

            return DS.Tables["aRoute"];
        }

        public static void updateRoute(int routeID, string departStation, string arrivalStation, double distance, char status)
        {
            con = new OracleConnection(DBConnect.oradb); con.Open();

            string SQL = 
                "UPDATE Stations SET departStation = '"
                + departStation + "', arrivalStation = '"
                + arrivalStation + "', distance = "
                + distance + ", status = '"
                + status + "' WHERE routeID =" + routeID + "";

            OracleCommand cmd = new OracleCommand(SQL, con);

            try
            {
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            con.Close();
        }
    }
}
