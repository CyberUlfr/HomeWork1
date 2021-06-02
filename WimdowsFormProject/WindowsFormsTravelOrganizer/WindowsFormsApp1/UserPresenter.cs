using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public class UserPresenter
    {
        public UserModel model;
        public JourneyModel jModel;
        public FormInput View;
        public UserPresenter(FormInput view, JourneyModel journeyModel, UserModel userModel)
        {
            jModel = journeyModel;
            View = view;
            model = userModel;
        }
        public List<User> UserGetList()
        {
            return model.Users;
        }
        public void SelectUser(User user)
        {
            View.Hide();
            model.SelectUser(user);
            if (user.IsAdmin)
            {
                FormAdmin fA = new FormAdmin();
                fA.Show();
            }
            else
            {
                FormSelectJourney fSJ = new FormSelectJourney(jModel, model);
                fSJ.Show();
            }
        }
        public void UserSave()
        {
            model.UserInit();
            UserDataBase.DataBaseSave(model.Users);
        }
    }
}
