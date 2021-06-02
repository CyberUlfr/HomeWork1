using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class DistancePresenter
    {
        public DistanceModel dModel;
        public FormUsers View;
        public DistancePresenter(FormUsers view, DistanceModel distanceModel)
        {
            View = view;
            dModel = distanceModel;
        }
        public void AddDistance(string distance, double kmeters)
        {
            try
            {
                dModel.AddDistance(distance, kmeters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        public void RemoveDistance(Distance distance)
        {
            dModel.RemoveDistance(distance);
        }
        public List<Distance> DistanceGetList()
        {
            return dModel.Distances;
        }
        public double StatisticDistance()
        {
            double sum = dModel.DistanceStatistic();
            return sum;
        }
    }
}
