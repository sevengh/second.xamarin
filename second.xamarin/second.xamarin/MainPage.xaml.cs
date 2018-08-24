using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace second.xamarin
{
    public partial class MainPage : ContentPage
    {
        Timer timer = new Timer(10000);
        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();

            timer.AutoReset = true;
            timer.Elapsed += new ElapsedEventHandler(DispatcherTimer_Tick);
            timer.Start();

            ChangeBackgrdound();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            ChangeBackgrdound();
        }

        void ChangeBackgrdound()
        {
            stackLayout.BackgroundColor =
                Color.FromRgb(
                    (byte)random.Next(255),
                    (byte)random.Next(255),
                    (byte)random.Next(255)
                    );
        }
    }
}
