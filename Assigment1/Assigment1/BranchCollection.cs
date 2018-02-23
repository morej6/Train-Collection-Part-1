//******************************************************
// File: BranchCollection.cs
//
// Purpose: Contains the class definition for BranchCollection.cs
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
    #region BranchCollection definition
    [DataContract]
    public class BranchCollection
    {
        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        #region private member varibles
        private List<Branch> m_branches;
        #endregion
        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public BranchCollection()
        {
            m_branches = new List<Branch>();
           
        }

        #region properties
        [DataMember(Name = "branches")]
        public List <Branch> branchList //Returns and sets data to the list
        {
            get
            {
                return m_branches;
            }
            set
            {
                m_branches = value;
            }
        }
        #endregion

        #region ToString
        //Custom toString for BranchCollection class
        public override string ToString()
        {
            String s = "";
            foreach (Branch n in m_branches)
            {
                s += "branches: " + n.ToString();
                s += "\n";
            }
            return s;
        }
        #endregion

        //****************************************************************************
        // Function: FindBranch
        //
        // Purpose: Checking if the branch id is in the list
        //
        //****************************************************************************
        public Branch FindBranch(int branchId) 
        {
            foreach (Branch n in m_branches)
            {
                if (branchId == n.BranchID)
                {
                    return n;
                }
            }
            return null;
        }


        //****************************************************************************
        // Function: FindBranch
        //
        // Purpose: Checking if the branch name is in the list
        //
        //****************************************************************************

        #region FindBranch
        public Branch FindBranch(string name) 
        {
            foreach (Branch n in m_branches)
            {
                if (name == n.BranchName)
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