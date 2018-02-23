using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1
{
    public class TrainScheduleUnitTesting
    {

        //****************************************************
        // Function: UnitTestStation 
        //
        // Purpose: To test get and set method for station class
        //
        //****************************************************
        public void UnitTestStation()
        {
            station m_station = new station();


            int InvalidID = -100;
            m_station.Id = InvalidID; //setting the invalid ID to the station class variable
            if (m_station.Id == InvalidID) //testing if the invalid variable is accepted.
            {
                Console.WriteLine("Station Invalid Id Property: Pass");

            }
            else
            {
                Console.WriteLine("Station Invalid Id Property: FAIL!");

            }

            int testID = 100;
            m_station.Id = testID; //setting the restID value to the station class variable 

            if (m_station.Id == testID) //testing if the testID value is accepted.
            {
                Console.WriteLine("Station Valid Id Property: Pass");

            }
            else
            {
                Console.WriteLine("Station Valid Id Property: FAIL!");
            }

            string testName = "juan";
            m_station.Name = testName; //setting the testName value to the station class variable

            if (m_station.Name == testName) //testing if the testName value is accepted.
            {
                Console.WriteLine("Station Valid Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Valid Name Property: FAIL!");
            }

            string testLocation = "Main St";
            m_station.location = testLocation; //setting the testlocation value to the station class variable

            if (m_station.Name == testLocation) //testing if the testLocation value is accepted.
            {
                Console.WriteLine("Station Valid Location Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Valid Location Property: FAIL!");
            }

            int testInvalidFareZone = -100;
            m_station.FareZone = testInvalidFareZone; //setting the testInvalidFareZone value to the station class variable

            if (m_station.Id == testInvalidFareZone) //testing if the testInvalidFareZone value is accepted.
            {
                Console.WriteLine("Station Invalid FareZone Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Invalid FareZone Property: FAIL!");
            }

            int testValidFareZone = 100;
            m_station.FareZone = testValidFareZone; //setting the testValidFareZone value to the station class variable
            if (m_station.FareZone == testValidFareZone) //testing if the testValidFareZone value is accepted.
            {
                Console.WriteLine("Station Valid FareZone Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Valid FareZone Property: FAIL!");
            }

            int testInvalidMileageToPenn = -100;
            m_station.MilageToPenn = testInvalidMileageToPenn; //setting the testInvalidMileageToPenn value to the station class variable
            if (m_station.MilageToPenn == testInvalidMileageToPenn) //testing if the testInvalidMileageToPenn value is accepted.
            {
                Console.WriteLine("Station Invalid MileageToPenn Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Invalid MileageToPenn Property: FAIL!");
            }

            int testValidMileageToPenn = 100;
            m_station.MilageToPenn = testValidMileageToPenn; //setting the testVaidMileageToPenn value to the station class variable
            if (m_station.MilageToPenn == testValidMileageToPenn) //testing if the testValidMileageTopPenn value is accepted.
            {
                Console.WriteLine("Station Valid MileageToPenn  Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Valid MileageToPenn Property: FAIL!");
            }

            string testValidPicFileName = "dog.jpg";
            m_station.PicFileName = testValidPicFileName; //setting the testValidPicFile value to the station class variable
            if (m_station.PicFileName == testValidPicFileName) //testing if the testVaidPicFilenName value is accepted.
            {
                Console.WriteLine("Station Valid PicFileName  Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Valid PicFileName Property: FAIL!");
            }



        }
    }
}

        /*
        //****************************************************
        // Function: UnitTestStationArrival 
        //
        // Purpose: To test get and set method for stationArrival class
        //
        //****************************************************
        public void UnitTestStationArrival()
        {
            StationArrival m_stationArrival = new StationArrival();
            int testInvalidID = -1;
            m_stationArrival.StationID = testInvalidID; //setting the testInvalidID value to the stationArrival class variable
            if (m_stationArrival.StationID == testInvalidID) //testing if the testInvalidID value is accepted.
            {
                Console.WriteLine("Station Invalid StationID  Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Invalid StationID Property: FAIL!");
            }

            int testValidID = 1;
            m_stationArrival.StationID = testValidID; //setting the testValidID value to the stationArrival class variable
            if (m_stationArrival.StationID == testValidID) //testing if the testValidID value is accepted.
            {
                Console.WriteLine("Station Valid StationID  Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Valid StationID Property: FAIL!");
            }


            DateTime time = new DateTime();
            string datestring = "2017/08/02";
            time = DateTime.Parse(datestring);

            m_stationArrival.Time = time; //setting the datestring value to the stationArrival class variable
            if (m_stationArrival.Time == time) //testing if the time value is accepted.
            {
                Console.WriteLine("Station Valid DateTime  Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Valid DateTime Property: FAIL!");
            }


            bool testValidTransferRequired = true;
            m_stationArrival.TransferRequired = testValidTransferRequired; //setting the testValidTransferR equire value to the stationArrival class variable
            if (m_stationArrival.TransferRequired == testValidTransferRequired) //testing if the testValidTransferRequired value is accepted.
            {
                Console.WriteLine("Station Valid TransferRequired  Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Valid TransferRequired Property: FAIL!");
            }








        }
    }
}
*/