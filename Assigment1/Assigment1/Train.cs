//******************************************************
// File: Train.cs
//
// Purpose: Contains the class definition for Train.cs
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
    #region Train definition
    [DataContract]
    public class Train
    {
        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        #region private member varibles
        private int m_trainId;
        private List<StationArrival> m_stationArrivals;
        #endregion
        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public Train()
        {
            m_trainId = 0;
            m_stationArrivals = new List<StationArrival>();
        }

        #region properties
        [DataMember(Name = "id")]
        public int trainId //{ get; set; } // sets and gets data from trainId
        {
            get
            {
                return m_trainId;
            }
            set
            {
                m_trainId = value;
            }
        }
        [DataMember(Name = "station_arrivals")]
        public List <StationArrival> stationArrivalList //Returns and sets data to the list
        {
            get
            {
                return m_stationArrivals;
            }
            set
            {
                m_stationArrivals = value;
            }
        }
        #endregion

        #region ToString
        //Custom toString for Train class
        public override string ToString()
        {
            String s = "";
            s += "Train ID: " + m_trainId;
            s += ", ";
            foreach (StationArrival n in m_stationArrivals)
            {
                s += "Station Arrivals: " + n.ToString();
              
            }
            s += "\n";
            return s;
        }
        #endregion
    }
}
#endregion