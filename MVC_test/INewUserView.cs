using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_test
{
    public delegate void NewUserEventHandler(INewUserView sender);

    public interface INewUserView
    {
        string Username { set; get; }

        string Password { set; get; }

        string Email { set; get; }

        void UserAlreadyExists();

        void UserSuccess();

        event NewUserEventHandler CreateNewUser;
    }
}
