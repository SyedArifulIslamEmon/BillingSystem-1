using System;

namespace MDL_Test
{
    class FactoryUser
    {
        static public User GetUserObject(int userTypeId, DateTime userCreatedDate)
        {
            User userObj = null;
            switch (userTypeId)
            {
                case 0:
                    userObj = new Customer(userCreatedDate, UserTypeEnum.Customer);
                    break;

                case 1:
                    userObj = new Affiliate(userCreatedDate, UserTypeEnum.Affiliate);
                    break;

                case 2:
                    userObj = new Employee(userCreatedDate, UserTypeEnum.Employee);
                    break;
            }
            return userObj;
        }
    }
}
