using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace TrainTicketSys
{
    class Routes
    {
        private static OracleConnection con;

        // Class Attributes
        private int routeID;
        private int departStation;
        private int arrivalStation;
        private double distance;
        private char status;

        // No Argument Constructor
        public Routes ()
        {
            this.routeID = 0; this.departStation = 0;
            this.arrivalStation = 0; this.distance = 0.00; this.status = ' ';
        }

        // Argument Constructor
        public Routes (int routeID, int departStation, int arrivalStation, double distance, char status)
        {
            setRouteID(routeID); setDepartStation(departStation); setArrivalStation(arrivalStation); setDistance(distance); setStatus(status);
        }

        // Setter and Getter Methods for Variables
        // Route ID
        public void setRouteID (int routeID)
        {
            this.routeID = routeID;
        }
        public int getRouteID ()
        {
            return this.routeID;
        }
        // Depart Station
        public void setDepartStation (int departStation)
        {
            this.departStation = departStation;
        }
        public int getDepartStation ()
        {
            return this.departStation;
        }
        // Arrival Station
        public void setArrivalStation (int arrivalStation)
        {
            this.arrivalStation = arrivalStation;
        }
        public int getArrivalStation ()
        {
            return this.arrivalStation;
        }
        // Distance
        public void setDistance (double distance)
        {
            this.distance = distance;
        }
        public double getDistance ()
        {
            return this.distance;
        }
        // Status
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
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                "INSERT INTO Routes VALUES ("
                + this.routeID + ","
                + this.departStation + ","
                + this.arrivalStation + ","
                + this.distance + ",UPPER('"
                + this.status + "'))";

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

        // Method To Get All Routes to Populate DataGrid
        public static DataSet getRoutes (DataSet DS, String sortOrder)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string SQL = @"SELECT 
                               R.RouteID AS routeID, SDepart.Name AS departStation, SArrival.Name AS arrivalStation, R.Distance AS distance, R.Status AS status
                           FROM 
                               Routes R

                               INNER JOIN STATIONS SDepart
                            ON 
                               SDepart.StationID = R.DepartStation
                               
                               INNER JOIN STATIONS SArrival
                            ON 
                               SArrival.StationID = R.ArrivalStation
                            ORDER BY " + sortOrder + ", arrivalStation";

            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);
            DA.Fill(DS, "Routes");

            con.Close();

            return DS;
        }

        // Method to Get Routes According To Departure Station
        public static DataSet getRoutesDepartStation (DataSet DS, String txtKeyWord)
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
                               R.RouteID AS routeID, SDepart.Name AS departStation, SArrival.Name AS arrivalStation, R.Distance AS distance, R.Status AS status
                           FROM 
                               Routes R
                               INNER JOIN STATIONS SDepart
                               ON SDepart.StationID = R.DepartStation
                               INNER JOIN STATIONS SArrival
                            ON 
                               SArrival.StationID = R.ArrivalStation
                            WHERE 
                               upper(SDepart.Name) LIKE '" + txtKeyWord.ToUpper() + "%' ORDER BY departStation, arrivalStation";

            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);
            DA.Fill(DS, "Routes");

            con.Close();

            return DS;
        }

        // Method to Retrieve All Active Routes
        public static DataSet getActiveRoutes(DataSet DS, String sortOrder)
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

            string SQL = @"SELECT R.RouteID AS routeID, SDepart.Name AS departStation, SArrival.Name AS arrivalStation, R.Distance AS distance, R.Status AS status
                           FROM Routes R
                                INNER JOIN STATIONS SDepart
                                ON SDepart.StationID = R.DepartStation
                                INNER JOIN STATIONS SArrival
                            ON SArrival.StationID = R.ArrivalStation
                            WHERE R.Status = 'A' ORDER BY " + sortOrder;

            OracleCommand cmd = new OracleCommand(SQL, con);
            OracleDataAdapter DA = new OracleDataAdapter(cmd);

            DA.Fill(DS, "Routes");
            con.Close();

            return DS;
        }

        // Method to Get a Route According to Route ID (RETURNING)
        public static DataTable getARoute (int routeID)
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

            string SQL = "SELECT * FROM Routes WHERE routeID = " + routeID + "";
            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            DA.Fill(DS, "aRoute");

            con.Close();

            return DS.Tables["aRoute"];
        }

        // Method to Get a Route According to Route ID (NOT RETURNING)
        public void getRoute(int routeID)
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

            string SQL = "SELECT * FROM Routes WHERE routeID = " + routeID + "";
            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            // Intantiate Instance Variables
            this.routeID = dr.GetInt32(0);
            this.departStation = dr.GetInt32(1);
            this.arrivalStation = dr.GetInt32(2);
            this.distance = dr.GetDouble(3);
            this.status = Convert.ToChar(dr.GetString(4));

            con.Close();
        }

        // Method To Update A Route
        public static void updateRoute(int routeID, string departStation, string arrivalStation, double distance, char status)
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
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        // Terminate A Route According To Station ID
        public static void terminateRouteByStation (int stationID)
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

            string SQL = @"UPDATE Routes SET status = 'T' WHERE departStation = " + stationID + " OR arrivalStation = " + stationID;
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

        // Terminate A Route According To Route ID
        public static void terminateRouteByRoute (int routeID)
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

            string SQL = @"UPDATE Routes SET status = 'T' WHERE routeID = " + routeID;
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
