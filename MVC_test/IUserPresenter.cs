using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_test
{
    public interface IUserPresenter
    {
        void AttachView(INewUserView userView);

        void DetachView(INewUserView userView);

        void Init(INewUserView userView);
    }
}
