using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        public List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for thisStaff
        clsStaff mThisStaff = new clsStaff();
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //later
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter db
            //var for the index
            int index = 0;
            //var for the record count
            int recordCount;
            //get theocount of records
            recordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (index < recordCount)
            {
                //create a blank staff template
                clsStaff AStaff = new clsStaff();
                //read the fields from the current records
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                AStaff.StaffActive = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffActive"]);
                AStaff.StaffAddress1 = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress1"]);
                AStaff.StaffAddress2 = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress2"]);
                AStaff.StaffDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateOfBirth"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                AStaff.StaffJobDescription = Convert.ToString(DB.DataTable.Rows[0]["StaffJobDescription"]);
                AStaff.StaffPasscode = Convert.ToInt32(DB.DataTable.Rows[0]["StaffPasscode"]);
                AStaff.StaffPostCode = Convert.ToString(DB.DataTable.Rows[0]["StaffPostCode"]);
                AStaff.StaffSurname = Convert.ToString(DB.DataTable.Rows[0]["StaffSurname"]);
                AStaff.StaffTel = Convert.ToString(DB.DataTable.Rows[0]["StaffTel"]);
                AStaff.StaffHourlyRate = Convert.ToDecimal(DB.DataTable.Rows[0]["StaffHourlyRate"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //increase index
                index++;
            }
        }

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            {
                DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
                DB.AddParameter("@StaffSurname", mThisStaff.StaffSurname);
                DB.AddParameter("@StaffAddress1", mThisStaff.StaffAddress1);
                DB.AddParameter("@StaffAddress2", mThisStaff.StaffAddress2);
                DB.AddParameter("@StaffPostCode", mThisStaff.StaffPostCode);
                DB.AddParameter("@StaffDateOfBirth", mThisStaff.StaffDateOfBirth);
                DB.AddParameter("@StaffTel", mThisStaff.StaffTel);
                DB.AddParameter("@StaffActive", mThisStaff.StaffActive);
                DB.AddParameter("@StaffJobDescription", mThisStaff.StaffJobDescription);
                DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
                DB.AddParameter("@StaffPasscode", mThisStaff.StaffPasscode);
                DB.AddParameter("@StaffHourlyRate", mThisStaff.StaffHourlyRate);

                return DB.Execute("sproc_tblSTaff_Add");
            }
        }

        public void Delete()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_DeleteByStaffID");
        }

        public void Update()
        {
            //create new instance of db connection
            clsDataConnection DB = new clsDataConnection();
            //set the parameters of the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffSurname", mThisStaff.StaffSurname);
            DB.AddParameter("@StaffAddress1", mThisStaff.StaffAddress1);
            DB.AddParameter("@StaffAddress2", mThisStaff.StaffAddress2);
            DB.AddParameter("@StaffPostCode", mThisStaff.StaffPostCode);
            DB.AddParameter("@StaffDateOfBirth", mThisStaff.StaffDateOfBirth);
            DB.AddParameter("@StaffTel", mThisStaff.StaffTel);
            DB.AddParameter("@StaffActive", mThisStaff.StaffActive);
            DB.AddParameter("@StaffJobDescription", mThisStaff.StaffJobDescription);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPasscode", mThisStaff.StaffPasscode);
            DB.AddParameter("@StaffHourlyRate", mThisStaff.StaffHourlyRate);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public clsStaffCollection()
        {
            //instance for db connection
            clsDataConnection DB = new clsDataConnection();
            //execure the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data
            PopulateArray(DB);
        }

        public void FilterByStaffID(int StaffID)
        {
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //send the staffid parameter to the db
            DB.AddParameter("@StaffID", StaffID);
            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            PopulateArray(DB);
        }

        public void FilterByStaffName(string StaffFirstName, string StaffSurname)
        {
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //send the staffid parameter to the db
            DB.AddParameter("@StaffFirstName", StaffFirstName);
            DB.AddParameter("@StaffSurname", StaffSurname);
            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}