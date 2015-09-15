using System;
using System.Configuration;

namespace MDL_Test
{
    public class Customer : User
    {
        private string _employeeDiscountFromConfig = ConfigurationManager.AppSettings["CustomerDiscount"];
        private string _minCustomerYearsForDiscountFromConfig = ConfigurationManager.AppSettings["MinCustomerYearsForDiscount"];
        private decimal _discountPer = 0;
        private int _minCustomerYearsForDiscount = 0;
        public Customer(string userName, int userId, DateTime userCreatedDate, UserTypeEnum userCategory)
            : base(userName, userId, userCreatedDate, userCategory)
       { }
        public override decimal DiscountPer
        {
            get
            {
                if (int.TryParse(_minCustomerYearsForDiscountFromConfig, out _minCustomerYearsForDiscount) 
                    && this.UserSince >= _minCustomerYearsForDiscount)
                {
                    if (decimal.TryParse(_employeeDiscountFromConfig, out _discountPer)) { }
                }
                return _discountPer;
            }
        }
    }
}
