//******************************************************
// File: Branch.cs
//
// Purpose: Contains the class definition for Branch.cs
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

    #region Branch definition
    [DataContract]
    public class Branch
    {
        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        #region private member varibles
        private int m_id;
        private string m_name;
        private List<int> m_stationIds;
        #endregion
        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public Branch()
        {
            m_id = 0;
            m_name = "";
            m_stationIds = new List<int>();
        }

        #region properties
        [DataMember(Name = "id")]
        public int BranchID { get; set; } //Returns and sets data to branchid
        [DataMember(Name = "name")]
        public string BranchName { get; set; } //Returns and sets data to branchname
        [DataMember(Name = "station_ids")]
        public List <int> stationList //Returns and sets data to the list
        {
            get
            {
                return m_stationIds;
            }
            set
            {
                m_stationIds = value;
            }
        }

        #endregion


        #region ToString
        //Custom toString for Branch class
        public override string ToString()
        {
            String s = "";
            s += "id: " + m_id;
            s += ", ";
            s += "name: " + m_name;
            s += ", ";
            foreach (int n in m_stationIds)
            {
                s += "stationIds: " + n;
            }
                
            s += "\n";
            return s;
        }
        #endregion
        //****************************************************************************
        // Function: IsBranchSttion
        //
        // Purpose: Checking if the stationId is in the list
        //
        //****************************************************************************
        #region IsBranchStation
        public bool IsBranchStation(int stationId)
        {
            foreach (int n in m_stationIds)
            {
                if(stationId == n)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

    }
}
#endregion