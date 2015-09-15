using System;

namespace MDL_Test
{
    public class Bill
    {
        private string _billId = string.Empty;
        private DateTime _billDate = DateTime.Now;

        private User _billUser = null;
        public User BillUser
        {
            get { return _billUser; }
            set { _billUser = value; }
        }

        private decimal _costOfGrocery = 0;
        public decimal CostOfGrocery
        {
            get { return _costOfGrocery; }
            set { _costOfGrocery = value; }
        }

        private decimal _grossAmount = 0;
        public decimal GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private decimal _netPayableAmount = 0;
        public decimal NetPayableAmount
        {
            get { return _netPayableAmount; }
            set { _netPayableAmount = value; }
        }

        public Bill(decimal grossAmount, decimal costOfGrocery, int userEnum, DateTime userCreatedDate)
        {
            this._grossAmount = grossAmount;
            this._costOfGrocery = costOfGrocery;
            this._billUser = FactoryUser.GetUserObject(userEnum, userCreatedDate);
        }
        public decimal GetNetPayableAmount()
        {
            if ((_billUser != null) && (_grossAmount >= _costOfGrocery) && (_grossAmount > 0) && (_costOfGrocery > 0) 
                    && _billUser.UserSince > 0)
            {
                decimal discountAmountFromPer = CalculateDiscountPer(_billUser, _grossAmount - _costOfGrocery);
                decimal discountAmountFromNonPer = CalculateNonDiscountPer(_grossAmount);
                _netPayableAmount = _grossAmount - (discountAmountFromNonPer + discountAmountFromPer);
                return _netPayableAmount;
            }
            else
            {
                return -1;
            }
        }

        private decimal CalculateNonDiscountPer(decimal grossAmount)
        {
            decimal nonPerDiscount = Math.Floor(grossAmount / 100);
            return nonPerDiscount * 5;
        }

        private decimal CalculateDiscountPer(User userObj, decimal amountAppForPercentageDiscount)
        {
            decimal discount = (amountAppForPercentageDiscount * userObj.DiscountPer) / 100;
            return discount;
        }
    }
}
