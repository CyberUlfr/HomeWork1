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
    public class SelectJourneyPresenter
    {
        public JourneyModel jModel;
        public UserModel uModel;
        public FormSelectJourney View;
        public SelectJourneyPresenter(FormSelectJourney view, JourneyModel journeyModel, UserModel userModel)
        {
            View = view;
            jModel = journeyModel;
            uModel = userModel;
        }
        public List<Journey> UserGetListJourney()
        {
            return jModel.Journeys;
        }
        public List<User> UserJGetList()
        {
            return jModel.Users;
        }
    }
}
