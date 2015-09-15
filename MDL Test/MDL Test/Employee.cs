using System;
using System.Configuration;

namespace MDL_Test
{
   public class Employee: User
    {
       private string employeeDiscountFromConfig = ConfigurationManager.AppSettings["EmployeeDiscount"];
       private decimal _discountPer = 0;

       public Employee(string userName, int userId, DateTime userCreatedDate, UserTypeEnum userCategory)
           : base(userName, userId, userCreatedDate, userCategory)
       { }

        public override decimal DiscountPer
        {
            get
            {
                if (decimal.TryParse(employeeDiscountFromConfig, out _discountPer)){}
                return _discountPer;
            }
        }
    }
}
