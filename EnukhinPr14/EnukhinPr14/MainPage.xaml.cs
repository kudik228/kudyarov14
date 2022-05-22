using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnukhinPr14
{
    public partial class MainPage : ContentPage
    {

        bool active = false;
        TimeSpan time = new TimeSpan(0,0,0);
        public MainPage()
        {
            InitializeComponent();
        }

        bool TimerTick()
        {
            if (active)
            {
                time += TimeSpan.FromSeconds(0.1);
                lableResult.Text = time.ToString(@"hh\:mm\:ss\:ff");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ButtonOnOff_Clicked(object sender, EventArgs e)
        {
            active = !active;
            if (active)
            {
                buttonOnOff.Text = "Выключить таймер";
                time = new TimeSpan(0, 0, 0);
                Device.StartTimer(TimeSpan.FromSeconds(0.1), TimerTick);

            }
            else
            {
                buttonOnOff.Text = "Включить таймер";
                lableResult.Text = DateTime.Now + " / " + lableResult.Text;
            }

        }
    }
}
