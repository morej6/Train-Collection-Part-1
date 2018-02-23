//******************************************************
// File: BranchSchedule.cs
//
// Purpose: Contains the class definition for BranchSchedule.cs
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
    #region BranchSchedule definition
    [DataContract]
    public class BranchSchedule
    {
        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        #region private member varibles
        private int m_branchId;
        private List<int> m_trainIds;
        #endregion
        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public BranchSchedule()
        {
            m_branchId = 0;
            m_trainIds = new List<int>();
        }
        #region properties
        [DataMember(Name = "id")]
        public int branchId// sets and gets data from branchid
        {
            get
            {
                return m_branchId;
            }
            set
            {
                m_branchId = value;
            }
        } 
        [DataMember(Name = "train_ids")]
        public List <int> trainId
        {
            get
            {
                return m_trainIds;
            }
            set
            {
                m_trainIds = value;
            }
        }
        #endregion

        #region ToString
        //Custom BranchSchedule for Station class
        public override string ToString()
        {
            String s = "";
            s += " m_branchId: " + m_branchId;
            s += ", ";
            foreach (int n in m_trainIds)
            {

                s += "m_trainIds: " + m_trainIds;
            }
            s += "\n";
            return s;
        }
        #endregion
    }
}
#endregion