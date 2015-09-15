using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MDL_Test;

namespace DiscountTest
{
    [TestClass]
    public class BillsTest
    {
        /// <summary>
        /// This method shall take all the valid value and return the expected output. 
        /// This is a positive scenario.
        /// </summary>
        [TestMethod]
        public void GetNetPayableAmount_WithValidAmount_ShouldPass()
        {
            decimal grossAmount = 4900;
            decimal costOfGrocery = 1000;
            int userEnum = 0;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);
            decimal actual = billObj.GetNetPayableAmount();

            decimal expected = 4460;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// In this method Cost of Grocery is less than Gross amount of the bill 
        /// which is not valid and hence the result from the GetNetPayableAmount method is -1.
        /// The expected value here suggests the outcome of a wrong data which is -1.
        /// This is a negative scenario.
        /// </summary>
        [TestMethod]
        public void GetNetPayableAmount_WithGrossAmountLessThanCostOfGrocery_ShouldPass()
        {
            decimal grossAmount = 900;
            int userEnum = 0;
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);
            decimal actual = billObj.GetNetPayableAmount();

            decimal expected = -1;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// In this method invalid user enum 5 is passed
        /// which is not valid and hence the result from the GetNetPayableAmount method is -1.
        /// The expected value here suggests the outcome of a wrong data which is -1.
        /// This is a negative scenario.
        /// </summary>
        [TestMethod]
        public void GetNetPayableAmount_WithInvalidUserType_ShouldPass()
        {
            decimal grossAmount = 1900;
            int userEnum = 5;
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);
            decimal actual = billObj.GetNetPayableAmount();

            decimal expected = -1;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// In this method UserCreatedDate is a future date  
        /// which is not valid and hence the result from the GetNetPayableAmount method is -1.
        /// The expected value here suggests the outcome of a wrong data which is -1.
        /// This is a negative scenario.
        /// </summary>
        [TestMethod]
        public void GetNetPayableAmount_WithFutureUserCreatedDate_ShouldPass()
        {
            decimal grossAmount = 4900;
            int userEnum = 0;
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2016");

            Bill billObj = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);
            decimal actual = billObj.GetNetPayableAmount();

            decimal expected = -1;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// In this method negative gross amount is passed 
        /// which is not valid and hence the result from the GetNetPayableAmount method is -1.
        /// The expected value here suggests the outcome of a wrong data which is -1.
        /// This is a negative scenario.
        /// </summary>
        
        [TestMethod]
        public void GetNetPayableAmount_WithNegativeGrossAmount_ShouldPass()
        {
            decimal grossAmount = -4900;
            int userEnum = 0;
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);
            decimal actual = billObj.GetNetPayableAmount();

            decimal expected = -1;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// In this method negative cost of grocery is passed 
        /// which is not valid and hence the result from the GetNetPayableAmount method is -1.
        /// The expected value here suggests the outcome of a wrong data which is -1.
        /// This is a negative scenario.
        /// </summary>
        
        [TestMethod]
        public void GetNetPayableAmount_WithNegativeCostOfGroceryAmount_ShouldPass()
        {
            decimal grossAmount = 1900;
            int userEnum = 0;
            decimal costOfGrocery = -1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);
            decimal actual = billObj.GetNetPayableAmount();

            decimal expected = -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBillUser_WithInvalidUserType_ShouldPass()
        {
            decimal grossAmount = 1900;
            int userEnum = 5;
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill actual = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);
            Bill expected = new Bill(grossAmount,costOfGrocery,1,userCreatedDate);

            Assert.AreNotEqual(expected.BillUser, actual.BillUser);
        }

        [TestMethod]
        public void GetCostOfGrocery_WithValidUserType_ShouldPass()
        {
            decimal grossAmount = 1900;
            int userEnum = 0;
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);

            decimal actual = billObj.CostOfGrocery;
            Assert.AreEqual(costOfGrocery, actual);
        }

        [TestMethod]
        public void GetGrossAmount_WithValidUserType_ShouldPass()
        {
            decimal grossAmount = 1900;
            int userEnum = 0;
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);

            decimal actual = billObj.GrossAmount;
            Assert.AreEqual(grossAmount, actual);
        }

        [TestMethod]
        public void SetGrossAmount_WithValidUserType_ShouldPass()
        {
            decimal grossAmount = 1900;
            int userEnum = 0;
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);

            decimal actual = billObj.GrossAmount;
            Assert.AreEqual(grossAmount, actual);
        }

        [TestMethod]
        public void GetNetPayableAmountProperty_WithValidUserType_ShouldPass()
        {
            decimal grossAmount = 4900;
            decimal costOfGrocery = 1000;
            int userEnum = 0;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill(grossAmount, costOfGrocery, userEnum, userCreatedDate);
            decimal actual = billObj.GetNetPayableAmount();

            decimal expected = 4460;
            Assert.AreEqual(expected, billObj.NetPayableAmount);
        }
    }
}
