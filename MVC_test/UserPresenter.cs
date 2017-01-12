using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_test
{
    public class UserPresenter : IUserPresenter
    {
        public void AttachView(INewUserView userView)
        {
            userView.CreateNewUser += UserView_CreateNewUser;
        }

        private void UserView_CreateNewUser(INewUserView sender)
        {
            if (sender.Email.Equals("vasya@pupkin", StringComparison.InvariantCultureIgnoreCase))
            {
                sender.UserAlreadyExists();
                return;
            }

            sender.UserSuccess();
        }

        public void DetachView(INewUserView userView)
        {
            userView.CreateNewUser -= UserView_CreateNewUser;
        }

        public void Init(INewUserView userView)
        {
            userView.Email = "enter your email";
            userView.Password = "*******";
            userView.Username = "Stark";
        }
    }
}
