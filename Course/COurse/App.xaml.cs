using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Course.Services;
using Course.Views;

namespace Course
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MockCourseCategories>();
            DependencyService.Register<MockCourseModelStore>();
            MainPage = new MainPage();
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
