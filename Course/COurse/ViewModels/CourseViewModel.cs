using Course.Models;
using Course.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Course.ViewModels
{
    public class CourseViewModel : BaseViewModel
    {

        //change to make data changes reflect to the ui 
        public string CourseName { get { return CourseModel.Name; } set { CourseModel.Name = value; OnPropertyChanged(); } }
        public CourseModel CourseModel { get; set; } = new CourseModel();

        public IEnumerable<CourseCategory> CourseCategories { get; set; }
        public ICommand AddCourseCommand { get; }


        private Page _page;

        public CourseViewModel(Page page)
        {
            _page = page;
            IntializeData();
            AddCourseCommand = new Command(async () => await AddCourseAsync());
        }

        public CourseViewModel(Page page, CourseModel course)
        {
            _page = page;
            IntializeData(course);
            AddCourseCommand = new Command(async () => await AddCourseAsync());
        }


        private async Task AddCourseAsync()
        {
            if (!ValidationHelper.IsFormValid(CourseModel, _page)) { return; }
             
            if (string.IsNullOrWhiteSpace(CourseModel.Id))

            await    CourseDataStore.AddItemAsync(CourseModel);
            else

                await CourseDataStore.UpdateItemAsync(CourseModel);
           
        }

        async void IntializeData(CourseModel course = null)
        {
            CourseCategories = await CourseCategoriesStore.GetItemsAsync();
            CourseModel = course ?? new CourseModel();// { Category = new CourseCategory() };
        }
    }
}
