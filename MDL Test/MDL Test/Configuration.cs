using System.Configuration;

namespace MDL_Test
{
    public class Configuration
    {
        public static string EmployeeDiscountFromConfig
        {
            get { return ConfigurationManager.AppSettings["EmployeeDiscount"]; }
        }

        public static string CustomerDiscountFromConfig
        {
            get { return ConfigurationManager.AppSettings["CustomerDiscount"]; }
        }

        public static string AffiliateDiscountFromConfig
        {
            get { return ConfigurationManager.AppSettings["AffiliateDiscount"]; }
        }

        public static string MinCustomerYearsForDiscountFromConfig
        {
            get { return ConfigurationManager.AppSettings["MinCustomerYearsForDiscount"]; }
        }
    }
}
