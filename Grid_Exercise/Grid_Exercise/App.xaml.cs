using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grid_Exercise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridSecondExercise_Page();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
