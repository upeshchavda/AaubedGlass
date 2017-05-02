using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace TestFrameworkUpesh
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the  list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffActive = true;
            TestItem.StaffAddress1 = "12 Alphabet Road";
            TestItem.StaffAddress2 = "Leicester";
            TestItem.StaffDateOfBirth = new DateTime(1996, 01, 01);
            TestItem.StaffEmail = "manager2@aaubedglass.co.uk";
            TestItem.StaffFirstName = "Upesh";
            TestItem.StaffID = 1002;
            TestItem.StaffJobDescription = "Managing Director";
            TestItem.StaffPasscode = 1998;
            TestItem.StaffPostCode = "LE2 7GZ";
            TestItem.StaffSurname = "Chavda";
            TestItem.StaffTel = "01122334455";
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStaff.mStaffList = TestList;
            //test to see that the two values are teh same
            Assert.AreEqual(AllStaff.mStaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create somem test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffActive = true;
            TestStaff.StaffAddress1 = "12 Alphabet Road";
            TestStaff.StaffAddress2 = "Leicester";
            TestStaff.StaffDateOfBirth = new DateTime(1996, 01, 01);
            TestStaff.StaffEmail = "manager2@aaubedglass.co.uk";
            TestStaff.StaffFirstName = "Upesh";
            TestStaff.StaffID = 1002;
            TestStaff.StaffJobDescription = "Managing Director";
            TestStaff.StaffPasscode = 1998;
            TestStaff.StaffPostCode = "LE2 7GZ";
            TestStaff.StaffSurname = "Chavda";
            TestStaff.StaffTel = "01122334455";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to tsee that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create a list of data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add items to the list
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffActive = true;
            TestItem.StaffAddress1 = "12 Alphabet Road";
            TestItem.StaffAddress2 = "Leicester";
            TestItem.StaffDateOfBirth = new DateTime(1996, 01, 01);
            TestItem.StaffEmail = "manager2@aaubedglass.co.uk";
            TestItem.StaffFirstName = "Upesh";
            TestItem.StaffID = 1002;
            TestItem.StaffJobDescription = "Managing Director";
            TestItem.StaffPasscode = 1998;
            TestItem.StaffPostCode = "LE2 7GZ";
            TestItem.StaffSurname = "Chavda";
            TestItem.StaffTel = "01122334455";
            //Add items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //add items to the list
            clsStaff TestItem = new clsStaff();
            //var for primary key
            int primaryKey = 0;
            //set its properties
            TestItem.StaffActive = true;
            TestItem.StaffAddress1 = "12 Alphabet Road";
            TestItem.StaffAddress2 = "Leicester";
            TestItem.StaffDateOfBirth = new DateTime(1996, 01, 01);
            TestItem.StaffEmail = "manager2@aaubedglass.co.uk";
            TestItem.StaffFirstName = "Upesh";
            TestItem.StaffID = 1002;
            TestItem.StaffJobDescription = "Managing Director";
            TestItem.StaffPasscode = 1998;
            TestItem.StaffPostCode = "LE2 7GZ";
            TestItem.StaffSurname = "Chavda";
            TestItem.StaffTel = "01122334455";
            TestItem.StaffHourlyRate = Convert.ToDecimal("7.99");
            //set thisstaff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            primaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = primaryKey;
            //find the record
            AllStaff.ThisStaff.Find(primaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //add items to the list
            clsStaff TestItem = new clsStaff();
            //var for primary key
            int primaryKey = 0;
            //set its properties
            TestItem.StaffActive = true;
            TestItem.StaffAddress1 = "12 Alphabet Road";
            TestItem.StaffAddress2 = "Leicester";
            TestItem.StaffDateOfBirth = new DateTime(1996, 01, 01);
            TestItem.StaffEmail = "manager2@aaubedglass.co.uk";
            TestItem.StaffFirstName = "Upesh";
            TestItem.StaffID = 1002;
            TestItem.StaffJobDescription = "Managing Director";
            TestItem.StaffPasscode = 1998;
            TestItem.StaffPostCode = "LE2 7GZ";
            TestItem.StaffSurname = "Chavda";
            TestItem.StaffTel = "01122334455";
            TestItem.StaffHourlyRate = Convert.ToDecimal("7.99");
            //set thisstaff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            primaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = primaryKey;
            //delete the record
            AllStaff.Delete();
            //Find the record
            Boolean Found = AllStaff.ThisStaff.Find(primaryKey);
            //test to see if the record no longer exists
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //add items to the list
            clsStaff TestItem = new clsStaff();
            //var for primary key
            int primaryKey = 0;
            //set its properties
            TestItem.StaffActive = true;
            TestItem.StaffAddress1 = "12 Alphabet Road";
            TestItem.StaffAddress2 = "Leicester";
            TestItem.StaffDateOfBirth = new DateTime(1996, 01, 01);
            TestItem.StaffEmail = "manager2@aaubedglass.co.uk";
            TestItem.StaffFirstName = "Upesh";
            TestItem.StaffID = 1002;
            TestItem.StaffJobDescription = "Managing Director";
            TestItem.StaffPasscode = 1998;
            TestItem.StaffPostCode = "LE2 7GZ";
            TestItem.StaffSurname = "Chavda";
            TestItem.StaffTel = "01122334455";
            TestItem.StaffHourlyRate = Convert.ToDecimal("7.99");
            //set thisstaff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            primaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = primaryKey;
            //modify the test data
            TestItem.StaffActive = false;
            TestItem.StaffAddress1 = "72 Newarke St";
            TestItem.StaffAddress2 = "Leicester";
            TestItem.StaffDateOfBirth = new DateTime(1996, 01, 01);
            TestItem.StaffEmail = "managerma@aaubedglass.co.uk";
            TestItem.StaffFirstName = "Upesh";
            TestItem.StaffID = 1002;
            TestItem.StaffJobDescription = "Manager";
            TestItem.StaffPasscode = 1998;
            TestItem.StaffPostCode = "LE2 7GZ";
            TestItem.StaffSurname = "Chavda";
            TestItem.StaffTel = "01122334455";
            TestItem.StaffHourlyRate = Convert.ToDecimal("19.93");
            //set the record based on the modified test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //test to see if the record no longer exists
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void FilterByStaffIDMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.FilterByStaffID(0);
            AllStaff.FilterByStaffID(0);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void FilterByStaffID_NoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.FilterByStaffID(0);
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void FilterByStaffIDTestDataFound()
        {
            //create instance of filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a staff id that doesnt exist
            FilteredStaff.FilterByStaffID(1001);
            if (FilteredStaff.Count == 1)
            {
                if (FilteredStaff.StaffList[0].StaffID != 1001)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        
    }
}
