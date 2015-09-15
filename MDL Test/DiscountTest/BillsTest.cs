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
            string userType = "customer";
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill();
            decimal nonPerDiscount = billObj.GetNetPayableAmount(grossAmount, costOfGrocery, userType, userCreatedDate);

            decimal actual = 4460;
            Assert.AreEqual(nonPerDiscount, actual);
        }

        /// <summary>
        /// In this method Cost of Grocery is less than Gross amount of the bill 
        /// which is not valid and hence the result from the GetNetPayableAmount method is -1.
        /// The actual value here suggests the Net Payable Amount had everything passed was correct.
        /// This is a negative scenario.
        /// </summary>
        [TestMethod]
        public void GetNetPayableAmount_WithGrossAmountLessThanCostOfGrocery_ShouldPass()
        {
            decimal grossAmount = 900;
            string userType = "customer";
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill();
            decimal nonPerDiscount = billObj.GetNetPayableAmount(grossAmount, costOfGrocery, userType, userCreatedDate);

            decimal actual = 4600;
            Assert.AreNotEqual(nonPerDiscount, actual);
        }

        /// <summary>
        /// In this method invalid usertype XXXX is passed
        /// which is not valid and hence the result from the GetNetPayableAmount method is -1.
        /// The actual value here suggests the Net Payable Amount had everything passed was correct.
        /// This is a negative scenario.
        /// </summary>
        [TestMethod]
        public void GetNetPayableAmount_WithInvalidUserType_ShouldPass()
        {
            decimal grossAmount = 1900;
            string userType = "XXXX";
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill();
            decimal nonPerDiscount = billObj.GetNetPayableAmount(grossAmount, costOfGrocery, userType, userCreatedDate);

            decimal actual = 4600;
            Assert.AreNotEqual(nonPerDiscount, actual);
        }

        /// <summary>
        /// In this method UserCreatedDate is a future date  
        /// which is not valid and hence the result from the GetNetPayableAmount method is -1.
        /// The actual value here suggests the Net Payable Amount had everything passed was correct.
        /// This is a negative scenario.
        /// </summary>
        [TestMethod]
        public void GetNetPayableAmount_WithFutureUserCreatedDate_ShouldPass()
        {
            decimal grossAmount = 4900;
            string userType = "customer";
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2016");

            Bill billObj = new Bill();
            decimal nonPerDiscount = billObj.GetNetPayableAmount(grossAmount, costOfGrocery, userType, userCreatedDate);

            decimal actual = 4460;
            Assert.AreNotEqual(nonPerDiscount, actual);
        }

        /// <summary>
        /// In this method negative gross amount is passed 
        /// which is not valid and hence the result from the GetNetPayableAmount method is -1.
        /// The actual value here suggests the Net Payable Amount had everything passed was correct.
        /// This is a negative scenario.
        /// </summary>
        
        [TestMethod]
        public void GetNetPayableAmount_WithNegativeGrossAmount_ShouldPass()
        {
            decimal grossAmount = -4900;
            string userType = "customer";
            decimal costOfGrocery = 1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill();
            decimal nonPerDiscount = billObj.GetNetPayableAmount(grossAmount, costOfGrocery, userType, userCreatedDate);

            decimal actual = 4460;
            Assert.AreNotEqual(nonPerDiscount, actual);
        }

        /// <summary>
        /// In this method negative cost of grocery is passed 
        /// which is not valid and hence the result from the GetNetPayableAmount method is -1.
        /// The actual value here suggests the Net Payable Amount had everything passed was correct.
        /// This is a negative scenario.
        /// </summary>
        
        [TestMethod]
        public void GetNetPayableAmount_WithNegativeCostOfGroceryAmount_ShouldPass()
        {
            decimal grossAmount = 1900;
            string userType = "customer";
            decimal costOfGrocery = -1000;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj = new Bill();
            decimal nonPerDiscount = billObj.GetNetPayableAmount(grossAmount, costOfGrocery, userType, userCreatedDate);

            decimal actual = 4460;
            Assert.AreNotEqual(nonPerDiscount, actual);
        }

    }
}
