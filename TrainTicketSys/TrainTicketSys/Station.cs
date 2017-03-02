using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace TrainTicketSys
{
    class Station
    {
        private static OracleConnection con;

        // Class Attributes
        private int stationID;
        private string name;
        private string street;
        private string town;
        private string county;
        private string phoneNo;
        private char status;

        // No Argument Constructor
        public Station ()
        {
            this.stationID = 0;
            this.name = "";
            this.street = "";
            this.town = "";
            this.county = "";
            this.phoneNo = "";
            this.status = 'C';
        }

        // All Argument Constructor
        public Station (int stationID, string name, string street, string town, string county, string phoneNo, char status)
        {
            setStationID(stationID); setName(name);
            setStreet(street); setTown(town);
            setCounty(county); setPhoneNo(phoneNo);
            setStatus(status);
        }

        // Setter and Getter Methods for Variables
        public void setStationID (int stationID)
        {
            this.stationID = stationID;
        }
        public int getStationID ()
        {
            return this.stationID;
        }

        public void setName (string name)
        {
            this.name = name;
        }
        public string getName ()
        {
            return this.name;
        }

        public void setStreet (string street)
        {
            this.street = street;
        }
        public string getStreet ()
        {
            return this.street;
        }

        public void setTown (string town)
        {
            this.town = town;
        }
        public string getTown ()
        {
            return this.town;
        }

        public void setCounty (string county)
        {
            this.county = county;
        }
        public string getCounty ()
        {
            return this.county;
        }

        public void setPhoneNo (string phoneNo)
        {
            this.phoneNo = phoneNo;
        }
        public string getPhoneNo ()
        {
            return this.phoneNo;
        }

        public void setStatus (char status)
        {
            this.status = status;
        }
        public char getStatus ()
        {
            return this.status;
        }

        // Method To Retrieve Next Station ID
        public static int nextStationID ()
        {
            int nextStationID;
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            String strSQL = "SELECT MAX(stationID) FROM Stations";

            OracleCommand cmd = new OracleCommand(strSQL, con);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0))
                nextStationID = 1;
            else
                nextStationID = Convert.ToInt32(dr.GetValue(0)) + 1;

            con.Close();
            return nextStationID;
        }

        // Method To Add A Station
        public void createStation ()
        {
            // Connect To DB
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            // Define SQL Query
            string strSQL =
                "INSERT INTO Stations VALUES ( "
                + this.stationID + ",'"
                + this.name + "','"
                + this.street + "','"
                + this.town + "','"
                + this.county + "','"
                + this.phoneNo + "','"
                + this.status + "')";

            // Execute Command/Query
            OracleCommand cmd = new OracleCommand(strSQL, con);
            cmd.ExecuteNonQuery();

            // Close Database
            con.Close();
        }

        // Method To Populate DataGrid
        public static DataSet getStations(DataSet DS, String sortOrder)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string SQL = "SELECT stationID, name, county, phoneNo, status FROM Stations ORDER BY " + sortOrder;

            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);
            DA.Fill(DS, "Stations");

            con.Close();

            return DS;
        }

        public static DataSet getActiveStations(DataSet DS, String sortOrder)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string SQL = "SELECT stationID, name, county, phoneNo, status FROM Stations WHERE status = 'A' ORDER BY " + sortOrder;

            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);
            DA.Fill(DS, "Stations");

            con.Close();

            return DS;
        }

        // Method To Populate DataGrid Relevant To A User Search
        public static DataSet getStationsName (DataSet DS, String txtKeyword)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string SQL = "SELECT stationID, name, county, phoneNo, status FROM Stations WHERE upper(name) LIKE '" + txtKeyword.ToUpper() + "%' ORDER BY stationID";

            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);
            DA.Fill(DS, "Stations");

            con.Close();

            return DS;
        }

        // Method to Get A Station
        public static DataTable getAStation (int stationID)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            string SQL = "SELECT * FROM Stations WHERE stationID = " + stationID + "";
            OracleCommand cmd = new OracleCommand(SQL, con);

            OracleDataAdapter DA = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            DA.Fill(DS, "aStation");

            con.Close();

            return DS.Tables["aStation"];
        }

        // Method To Update A Station
        public static void updateStation (int stationID, string name, string street, string town, string county, string phoneNo, char status)
        {
            con = new OracleConnection(DBConnect.oradb); con.Open();

            string SQL = "UPDATE Stations SET name = '"
                + name + "', street = '"
                + street + "', town = '"
                + town + "', county = '"
                + county + "', phoneNo = '"
                + phoneNo + "', status = '"
                + status + "' WHERE stationID =" + stationID + "";

            OracleCommand cmd = new OracleCommand(SQL, con);
            cmd.ExecuteNonQuery();
            

            con.Close();
        }
    }
}