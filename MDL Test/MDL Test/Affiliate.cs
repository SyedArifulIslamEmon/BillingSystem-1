using System;
using System.Configuration;

namespace MDL_Test
{
   public class Affiliate:User
    {
       private string _affiliateDiscountFromConfig = ConfigurationManager.AppSettings["AffiliateDiscount"];
       private decimal _discountPer = 0;

        public Affiliate(string userName, int userId, DateTime userCreatedDate, UserTypeEnum userCategory)
            : base(userName, userId, userCreatedDate, userCategory)
       { }
        public override decimal DiscountPer
        {
            get
            {
                if (decimal.TryParse(_affiliateDiscountFromConfig, out _discountPer)) { }
                return _discountPer;
            }
        }
    }
}
