using System;

namespace MDL_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal grossAmount = 4900;
            decimal costOfGrocery = 1000;
            int userEnum = 0;
            DateTime userCreatedDate = DateTime.Parse("05/09/2013");

            Bill billObj1 = new Bill(grossAmount,costOfGrocery,userEnum,userCreatedDate);
            decimal netPayableAmount1 = billObj1.GetNetPayableAmount();
            Console.WriteLine("Net Payable Amount: {0}", netPayableAmount1);
        }
    }
}
