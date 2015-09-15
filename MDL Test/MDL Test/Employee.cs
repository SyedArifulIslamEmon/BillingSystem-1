using System;
using System.Configuration;

namespace MDL_Test
{
    public class Employee : User
    {
        private decimal _discountPer = 0;

        public Employee(DateTime userCreatedDate, UserTypeEnum userCategory)
            : base(userCreatedDate, userCategory)
        { }
        public override decimal DiscountPer
        {
            get
            {
                if (decimal.TryParse(Configuration.EmployeeDiscountFromConfig, out _discountPer)) { }
                return _discountPer;
            }
        }
    }
}
