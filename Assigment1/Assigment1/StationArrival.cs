//******************************************************
// File: StationArrival.cs
//
// Purpose: Contains the class definition for StationArrival.cs
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
    #region StationArrival definition  
    [DataContract]
  public class StationArrival
    {

        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        #region private member varibles
        private int m_stationID;
        private DateTime m_Time;
        private int m_trainID;
        // private bool m_TransferRequire;
        #endregion
        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public StationArrival()
        {
            m_stationID = 0;
            m_Time = new DateTime(2017, 01, 01);
            m_trainID = 0;
         //   m_TransferRequire = false;
           
        }

        #region properties
        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "station_id")]
        public int StationID // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_stationID;
            }
            set
            {
                if (value >= 0)
                {
                    m_stationID = value;
                }
            }
        }

        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "time")]
        public DateTime Time // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_Time;
            }
            set
            {
                m_Time = value;
            }
        }

        [DataMember(Name = "train_id")]
        public int TrainID
        {
            get
            {
                return m_trainID;
            }
            set
            {
                m_trainID = value;
            }
        }

        /*
        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "Transfer_Required")]
        
        public bool TransferRequired // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_TransferRequire;
            }
            set
            {
                m_TransferRequire = value;
            }
        }
        */

        #endregion

        #region ToString
        //Custom toString for stationArrival class
        public override string ToString()
        {
            String s = "";
            s +="Station ID: " +m_stationID;
            s += ", ";
            s +="Time: "+ m_Time;
            s += ", ";
            s += "TrainID: " + m_trainID;
         //   s +="Transfer Require: "+ m_TransferRequire;
            s += "\n";
            return s;
        }
        #endregion


    }
}
#endregion