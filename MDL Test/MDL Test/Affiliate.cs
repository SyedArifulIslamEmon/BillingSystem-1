using System;
using System.Configuration;

namespace MDL_Test
{
   public class Affiliate:User
    {
       
       private decimal _discountPer = 0;

        public Affiliate(DateTime userCreatedDate, UserTypeEnum userCategory)
            : base(userCreatedDate, userCategory)
       { }
        public override decimal DiscountPer
        {
            get
            {
                if (decimal.TryParse(Configuration.AffiliateDiscountFromConfig, out _discountPer)) { }
                return _discountPer;
            }
        }
    }
}
