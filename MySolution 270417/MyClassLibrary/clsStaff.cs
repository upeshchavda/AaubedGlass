using System;

namespace MyClassLibrary
{
    public class clsStaff
    {
        private bool mStaffActive;
        private string mStaffTel;
        private string mStaffSurname;
        private string mStaffPostCode;
        private int mStaffPasscode;
        private string mStaffJobDescription;
        private int mStaffID;
        private decimal mStaffHourlyRate;
        private string mStaffFirstName;
        private string mStaffEmail;
        private DateTime mStaffDateOfBirth;
        private string mStaffAddress2;
        private string mStaffAddress1;

        public bool StaffActive
        {
            get
            {
                return mStaffActive;
            }
            set
            {
                mStaffActive = value;
            }
        }
        public string StaffAddress1
        {
            get
            {
                return mStaffAddress1;
            }
            set
            {
                mStaffAddress1 = value;
            }
        }
        public string StaffAddress2
        {
            get
            {
                return mStaffAddress2;
            }
            set
            {
                mStaffAddress2 = value;
            }
        }
        public DateTime StaffDateOfBirth
        {
            get
            {
                return mStaffDateOfBirth;
            }
            set
            {
                mStaffDateOfBirth = value;
            }
        }
        public string StaffEmail
        {
            get
            {
                return mStaffEmail;
            }
            set
            {
                mStaffEmail = value;
            }
        }
        public string StaffFirstName
        {
            get
            {
                return mStaffFirstName;
            }
            set
            {
                mStaffFirstName = value;
            }
        }
        public decimal StaffHourlyRate
        {
            get
            {
                return mStaffHourlyRate;
            }
            set
            {
                mStaffHourlyRate = value;
            }
        }
        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public string StaffJobDescription
        {
            get
            {
                return mStaffJobDescription;
            }
            set
            {
                mStaffJobDescription = value;
            }
        }
        public int StaffPasscode
        {
            get
            {
                return mStaffPasscode;
            }
            set
            {
                mStaffPasscode = value;
            }
        }
        public string StaffPostCode
        {
            get
            {
                return mStaffPostCode;
            }
            set
            {
                mStaffPostCode = value;
            }
        }
        public string StaffSurname
        {
            get
            {
                return mStaffSurname;
            }
            set
            {
                mStaffSurname = value;
            }
        }
        public string StaffTel
        {
            get
            {
                return mStaffTel;
            }
            set
            {
                mStaffTel = value;
            }
        }

        public bool Valid(bool staffActive, string staffAddress1, string staffAddress2, string staffEmail, string staffFirstName, string staffJobDescription, string staffPostcode, string staffSurname, string staffTel, DateTime staffDateOfBirth, int staffID, int staffPasscode)
        {
            Boolean OK = true;

            //STAFFADDRESS1
            if (staffAddress1.Length == 0)
            {
                OK = false;
            }
            else if (staffAddress1.Length > 20)
            {
                OK = false;
            }
            //END STAFFADDRESS1

            //STAFFADDRESS2
            if (staffAddress2.Length == 0)
            {
                OK = false;
            }
            else if (staffAddress2.Length > 20)
            {
                OK = false;
            }
            //END STAFFADDRESS2

            //POSTCODE
            if (staffPostcode.Length < 5)
            {
                OK = false;
            }
            else if (staffPostcode.Length > 8)
            {
                OK = false;
            }
            //END POSTCODE

            //TEL
            if (staffTel.Length > 11)
            {
                OK = false;
            }
            else if (staffTel.Length < 11)
            {
                OK = false;
            }
            //END TEL

            //JOB DESC
            if (staffJobDescription.Length > 20)
            {
                OK = false;
            }
            else if (staffJobDescription.Length < 5)
            {
                OK = false;
            }
            //END JOB DESC

            //DOB
            if (staffDateOfBirth.Date < DateTime.Now.Date.AddYears(-100))
            {
                OK = false;
            }
            else if (staffDateOfBirth.Date > DateTime.Now.Date.AddYears(-18))
            {
                OK = false;
            }
            //END DOB

            //EMAIL
            if (staffEmail.Length > 40)
            {
                OK = false;
            }
            else if (staffEmail.Length < 9)
            {
                OK = false;
            }
            //END EMAIL

            //ID
            if (staffID < 1001)
            {
                OK = false;
            }
            else if (staffID > 9999)
            {
                OK = false;
            }
            //END ID

            //PASSCODE
            String Passcode = staffPasscode.ToString();
            if (Passcode.Length != 4)
            {
                OK = false;
            }
            //END PASSCODE

            return OK;
        }

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if record found
            if (DB.Count == 1)
            {
                //copy data from db to variables
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffActive = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffActive"]);
                mStaffAddress1 = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress1"]);
                mStaffAddress2 = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress2"]);
                mStaffDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateOfBirth"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffJobDescription = Convert.ToString(DB.DataTable.Rows[0]["StaffJobDescription"]);
                mStaffPasscode = Convert.ToInt32(DB.DataTable.Rows[0]["StaffPasscode"]);
                mStaffPostCode = Convert.ToString(DB.DataTable.Rows[0]["StaffPostCode"]);
                mStaffSurname = Convert.ToString(DB.DataTable.Rows[0]["StaffSurname"]);
                mStaffTel = Convert.ToString(DB.DataTable.Rows[0]["StaffTel"]);
                mStaffHourlyRate = Convert.ToDecimal(DB.DataTable.Rows[0]["StaffHourlyRate"]);
                
                //return confirmed
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}