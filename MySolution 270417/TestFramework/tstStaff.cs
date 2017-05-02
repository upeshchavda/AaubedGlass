using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see if the class exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.StaffActive = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffActive, TestData);
        }

        [TestMethod]
        public void StaffAddress1PropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "40 Grange Lane";
            //assign the data to the property
            AStaff.StaffAddress1 = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffAddress1, TestData);
        }

        [TestMethod]
        public void StaffAddress2PropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Leicester";
            //assign the data to the property
            AStaff.StaffAddress2 = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffAddress2, TestData);
        }

        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "manager@aaubedglass.co.uk";
            //assign the data to the property
            AStaff.StaffEmail = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Akshay";
            //assign the data to the property
            AStaff.StaffFirstName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffFirstName, TestData);
        }

        [TestMethod]
        public void StaffJobDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Assistant Manager";
            //assign the data to the property
            AStaff.StaffJobDescription = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffJobDescription, TestData);
        }

        [TestMethod]
        public void StaffPostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "LE2 7HJ";
            //assign the data to the property
            AStaff.StaffPostCode = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffPostCode, TestData);
        }

        [TestMethod]
        public void StaffSurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Hurkoo";
            //assign the data to the property
            AStaff.StaffSurname = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffSurname, TestData);
        }

        [TestMethod]
        public void StaffTelPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "07891234567";
            //assign the data to the property
            AStaff.StaffTel = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffTel, TestData);
        }

        [TestMethod]
        public void StaffDateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = new DateTime(1996, 10, 19);
            //assign the data to the property
            AStaff.StaffDateOfBirth = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffDateOfBirth, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1001;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffPasscodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 4679;
            //assign the data to the property
            AStaff.StaffPasscode = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffPasscode, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress1ExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffAddress1MinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffAddress1Min()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "A";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress1MinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "Aa";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress1MaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "1234567890123456789";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress1Max()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "12345678901234567890";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress1MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "123456789012345678901";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffAddress1Mid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "1234567890";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress1ExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "1234567890123456789012345678901234567890";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffAddress2ExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffAddress2MinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffAddress2Min()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "A";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress2MinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Aa";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress2MaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "1234567890123456789";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress2Max()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "12345678901234567890";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress2MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "123456789012345678901";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffAddress2Mid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "1234567890";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddress2ExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "1234567890123456789012345678901234567890";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPostCodeExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "XXXX";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPostCodeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "L11EF";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "L1 1EF";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE1 1EF";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPostCodeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE11 1EF";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE11 51EF";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "X1X1X1X1X1";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffTelExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffTelMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "0123456789";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffTelMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "01234567890";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffTelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "012345678901";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffTelMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "01234567891";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffTelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "0123456789";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffTelMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "01234567890";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffTelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "012345678901";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffTelExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "01234567890123456789";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffJobDescriptionExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void StaffJobDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "abcd";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffJobDescriptionMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "abcde";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffJobDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "abcdef";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffJobDescriptionMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "abcdefghijkl";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffJobDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "abcdefghijklmnopqrs";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StaffJobDescriptionMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "abcdefghijklmnopqrst";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffJobDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "abcdefghijklmnopqrstuvw";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffJobDescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "abcdefghijklmnopqrstuvwxy";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffDOBExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1850, 01, 01);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffDOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = DateTime.Now.Date.AddYears(-100).AddDays(-1);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffDOBMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = DateTime.Now.Date.AddYears(-100);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = DateTime.Now.Date.AddYears(-100).AddDays(1);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = DateTime.Now.Date.AddYears(-59);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = DateTime.Now.Date.AddYears(-18).AddDays(-1);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = DateTime.Now.Date.AddYears(-18);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = DateTime.Now.Date.AddYears(-18).AddDays(1);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffDOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = DateTime.Now.Date;
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffIDExtremeMinValue()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 900;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffIDMinLessOneValue()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1000;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StaffIDMinValue()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffIDMinPlusOneValue()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1002;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffIDMidValue()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 5000;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffIDMaxLessOneValue()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 9998;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffIDMaxValue()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 9999;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffIDMaxPlusOneValue()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 10000;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffIDExtremeMaxValue()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 12345;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPasscodeExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 1;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPasscodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 123;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPasscodeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 1234;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPasscodeMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 1234;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPasscodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 12345;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPasscodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 123;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPasscodeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 1234;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPasscodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 12345;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPasscodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "manager@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 1234567890;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffEmailExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "@";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "ab@ab.co";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffEmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "ab@ab.com";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "abc@ab.com";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "akshayh@aaubedglass.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "akshayhurkoo1996@aaubedglasshotel.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "akshay.hurkoo1996@aaubedglasshotel.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "akshay.hurkoo.1996@aaubedglasshotel.co.uk";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            Boolean StaffActive = true;
            string StaffAddress1 = "40 Grange Lane";
            string StaffAddress2 = "Leicester";
            string StaffEmail = "akshay.hurkoo.1996@aaubedglasshotel.co.uk1234567890";
            string StaffFirstName = "Akshay";
            string StaffJobDescription = "Assistant Manager";
            string StaffPostcode = "LE2 7HJ";
            string StaffSurname = "Hurkoo";
            string StaffTel = "07891234567";
            DateTime StaffDateOfBirth = new DateTime(1996, 10, 19);
            Int32 StaffID = 1001;
            Int32 StaffPasscode = 4679;
            //invoke the method
            OK = AStaff.Valid(StaffActive, StaffAddress1, StaffAddress2, StaffEmail, StaffFirstName, StaffJobDescription, StaffPostcode, StaffSurname, StaffTel, StaffDateOfBirth, StaffID, StaffPasscode);
            //test to see that the result is true
            Assert.IsFalse(OK);
        }


    }
}
