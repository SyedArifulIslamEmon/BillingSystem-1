using System.Configuration;

namespace MDL_Test
{
    public static class Configuration
    {
        private static string _employeeDiscountFromConfig = ConfigurationManager.AppSettings["EmployeeDiscount"];
        public static string EmployeeDiscountFromConfig
        {
            get { return Configuration._employeeDiscountFromConfig; }
        }


        private static string _customerDiscountFromConfig = ConfigurationManager.AppSettings["CustomerDiscount"];
        public static string CustomerDiscountFromConfig
        {
            get { return Configuration._customerDiscountFromConfig; }
        }


        private static string _affiliateDiscountFromConfig = ConfigurationManager.AppSettings["AffiliateDiscount"];
        public static string AffiliateDiscountFromConfig
        {
            get { return Configuration._affiliateDiscountFromConfig; }
        }

        private static string _minCustomerYearsForDiscountFromConfig = ConfigurationManager.AppSettings["MinCustomerYearsForDiscount"];
        public static string MinCustomerYearsForDiscountFromConfig
        {
            get { return Configuration._minCustomerYearsForDiscountFromConfig; }
        }
    }
}
