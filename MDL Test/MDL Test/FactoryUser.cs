using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL_Test
{
    class FactoryUser
    {
        static public User GetUserObject(int userTypeId, DateTime userCreatedDate, int userId, string userName)
        {
            User userObj = null;
            switch (userTypeId)
            {
                case 0:
                    userObj = new Customer(userName, userId, userCreatedDate, UserTypeEnum.Customer);
                    break;

                case 1:
                    userObj = new Affiliate(userName, userId, userCreatedDate, UserTypeEnum.Affiliate);
                    break;

                case 2:
                    userObj = new Employee(userName, userId, userCreatedDate, UserTypeEnum.Employee);
                    break;
            }
            return userObj;
        }
    }
}
