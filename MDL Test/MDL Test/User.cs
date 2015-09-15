using System;

namespace MDL_Test
{
    public abstract class User
    {
        private string _userName;
        private int _userID;
        private DateTime _userCreatedDate;
        private UserTypeEnum _userCategory;
        private int _userSince;

        public User(string userName, int userID, DateTime userCreatedDate, UserTypeEnum userCategory)
        {
            this._userID = userID;
            this._userName = userName;
            this._userCreatedDate = userCreatedDate;
            this._userCategory = userCategory;
            this._userSince = GetUsersAge(_userCreatedDate);
        }

        public User(DateTime userCreatedDate, UserTypeEnum userCategory)
        {
            this._userCreatedDate = userCreatedDate;
            this._userCategory = userCategory;
            this._userSince = GetUsersAge(_userCreatedDate);
        }

        public int UserSince
        {
            get
            {
                return _userSince;
            }
        }

        public abstract decimal DiscountPer
        {
            get;
        }

        public UserTypeEnum UserCategory
        {
            get
            {
                return _userCategory;
            }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        public static int GetUsersAge(DateTime userCreatedDate)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - userCreatedDate.Year;
            if (userCreatedDate > now.AddYears(-age)) age--;

            if (age > 0)
                return age;
            else
                return 0;
        }
    }
}
