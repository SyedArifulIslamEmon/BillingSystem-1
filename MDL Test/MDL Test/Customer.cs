using System;
using System.Configuration;

namespace MDL_Test
{
    public class Customer : User
    {
        private decimal _discountPer = 0;
        private int _minCustomerYearsForDiscount = 0;
        public Customer(DateTime userCreatedDate, UserTypeEnum userCategory)
            : base(userCreatedDate, userCategory)
       { }
        public override decimal DiscountPer
        {
            get
            {
                if (int.TryParse(Configuration.MinCustomerYearsForDiscountFromConfig, out _minCustomerYearsForDiscount) 
                    && this.UserSince >= _minCustomerYearsForDiscount)
                {
                    if (decimal.TryParse(Configuration.CustomerDiscountFromConfig, out _discountPer)) { }
                }
                return _discountPer;
            }
        }
    }
}
