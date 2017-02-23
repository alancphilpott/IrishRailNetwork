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

        public static ComboBox fillDropDown (ComboBox comboBox)
        {
            OracleDataReader DR;
            try
            {
                con = new OracleConnection(DBConnect.oradb);
                con.Open();

                if (comboBox.Items.Count > 0)
                    comboBox.Items.Clear();

                String strSQL = "SELECT name FROM Stations";

                OracleCommand cmd = new OracleCommand(strSQL, con);
                DR = cmd.ExecuteReader();

                while (DR.Read())
                    comboBox.Items.Add(DR[0]);

                DR.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            return comboBox;
        }
    }
}
