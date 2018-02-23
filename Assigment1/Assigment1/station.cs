//******************************************************
// File: station.cs
//
// Purpose: Contains the class definition for station.cs
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
    #region station definition
    [DataContract]
  public  class station
    {
        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        #region private member varibles
        private int m_Id;
        private string m_Name;
        private string m_Location;
        private int m_FareZone;
        private double m_MileageToPenn;
        private string m_PicFileName;
        #endregion

        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public station()
        {
            m_Id = 0;
            m_Name = "null";
            m_Location = "null";
            m_FareZone = 0;
            m_MileageToPenn = 0;
            m_PicFileName = "null";
        }

        #region properties
        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "id")]
        public int Id // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_Id;
            }
            set
            {
                if (value >= 0)
                {
                    m_Id = value;
                }
            }
        }

        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "name")]
        public string Name // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "location")]
        public string location // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_Location;
            }
            set
            {
                m_Location = value;
            }
        }

        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "fare_zone")]
        public int FareZone // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_FareZone;
            }
            set
            {
                if (value >= 0)
                {
                    m_FareZone = value;
                }
            }
        }

        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "mileage_to_penn")]
        public double MilageToPenn // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_MileageToPenn;
            }
            set
            {
                if (value >= 0)
                {

                    m_MileageToPenn = value;
                }
            }
        }

        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "pic_filename")]
        public string PicFileName // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_PicFileName;
            }
            set
            {
                m_PicFileName = value;
            }
        }
        #endregion

        #region ToString
        //Custom toString for Station class
        public override string ToString()
        {
            String s = "";
            s +="ID: " + m_Id;
            s += ", ";
            s += "Name: "+ m_Name;
            s += ", ";
            s += "Location: "+m_Location;
            s += ", ";
            s += "Fare Zone: "+ m_FareZone;
            s += ", ";
            s +="Mileage To Penn: "+ m_MileageToPenn;
            s += ", ";
            s += "Pic File Name: " + m_PicFileName;
            s += "\n";
            return s;
        }
        #endregion

    }
}
#endregion