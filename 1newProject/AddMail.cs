using _1newProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1newProject
{
    public class AddMail
    {
        public void AddUserMail(UserModel.ReturnData returnData)
        {
            returnData.Mail = "kayhan1901@gmail.com";

           AddAge addAge = new AddAge();
           addAge.AddUserAge(returnData);

        }
    }
}
