using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ClassLibrary1;
using System.Collections.Generic;
using System;
using System.Linq;

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
        public List<User> UserJGetList()
        {
            return jModel.Users;
        }
        public void UserAddJourney(User user)
        {
            try
            {
                jModel.UserAddJourney(user);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        public void JourneyAdd(string name, List<User> users)
        {
            try
            {
                if (name.Trim() != "")
                {
                    jModel.JourneyAdd(name, users);
                }
                else
                {
                    MessageBox.Show("Ошибка! Данные введены не верно!", "Ошибка!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        public void JourneyRemove(Journey journey)
        {
            jModel.JourneyRemove(journey);
        }
        public void UserRemoveJourney(User user)
        {
            jModel.UserRemoveJourney(user);
        }
        
    }
}
