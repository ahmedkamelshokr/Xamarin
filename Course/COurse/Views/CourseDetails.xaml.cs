using Course.Models;
using Course.Services;
using Course.ViewModels;
using System;
using System.Collections.Generic;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseDetails : ContentPage
    {
        public CourseViewModel CourseModel { get; set; }
        public CourseDetails()
        {
            InitializeComponent();
            CourseModel = new CourseViewModel(this);
            BindingContext = CourseModel;

        }

        public CourseDetails(CourseModel course)
        {
            InitializeComponent();
            CourseModel = new CourseViewModel(this);
            CourseModel.CourseModel = course;

            BindingContext = CourseModel;

        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {

            Navigation.PopModalAsync();
           // Navigation.PopAsync();
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "CourseSaved", CourseModel.CourseModel);
            Navigation.PopModalAsync();
        }
    }
}