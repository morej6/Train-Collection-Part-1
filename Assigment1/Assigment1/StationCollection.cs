//******************************************************
// File: StationCollection.cs
//
// Purpose: Contains the class definition for StationCollection.cs
//
// Written By: Juan Moreno
//
// Compiler: Visual Studio 2015
//
//******************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
namespace Assigment1
{

    #region StationCollection definition
    [DataContract]
    public class StationCollection 
    {

        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        #region private member varibles
        private List<station> m_stations;
        #endregion
        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public StationCollection()
        {
            m_stations = new List<station>();
        }

        #region properties
        [DataMember(Name = "stations")]
        public List <station> stationList //Returns and sets data to the list
        {
            get
            {
                return m_stations;
            }
            set
            {
                m_stations = value;
            }
            
        }
        #endregion

        #region ToString
        //Custom toString for StationCollection class
        public override string ToString()
        {
            String s = "";
            foreach (station n in m_stations)
            {
                s += "Station: " + n.ToString();
                s += "\n";
            }
            return s;
        }

        #endregion
        //****************************************************************************
        // Function: FindStation
        //
        // Purpose: Checking if the StationID is in the list
        //
        //****************************************************************************
        #region FindStation
        public station FindStation(int stationid)
        {
            foreach(station n in m_stations)
            {
                if (stationid == n.Id)
                {
                    return n;
                }
            }
            return null;
        }
        #endregion
        //****************************************************************************
        // Function: FindStation
        //
        // Purpose: Checking if the Station name is in the list
        //
        //****************************************************************************
        #region FindStation
        public station FindStation(string name)
        {
            foreach (station n in m_stations)
            {
                if (name == n.Name)
                {
                    return n;
                }
            }
            return null;
        }
        #endregion
    }
}
#endregion