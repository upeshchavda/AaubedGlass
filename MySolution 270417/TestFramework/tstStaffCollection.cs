using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace TestFramework
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
            AllStaff.StaffList = TestList;
            //test to see that the two values are teh same
            Assert.AreEqual(AllStaff.StaffList, TestList);
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
    }
}
