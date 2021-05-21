using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ClassLibrary1;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class JourneyPresenter
    {
        public JourneyModel jModel;
        public UserModel uModel;
        public FormAdmin View;
        public JourneyPresenter(FormAdmin view, JourneyModel journeyModel, UserModel userModel)
        {
            View = view;
            jModel = journeyModel;
            uModel = userModel;
        }
        public List<Journey> UserGetListJourney()
        {
            return jModel.Journeys;
        }
    }
}
