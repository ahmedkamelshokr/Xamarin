using Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Services
{
    public class MockCourseModelStore : IDataStore<CourseModel>
    {
        List<CourseModel> courses;


        public MockCourseModelStore()
        {
            courses = new List<CourseModel>()
            {
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "First course",  Summary="This is an course description." },
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "Second course", Summary="This is an course description." },
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "Third course",  Summary="This is an course description." },
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "Fourth course", Summary="This is an course description." },
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "Fifth course",  Summary="This is an course description." },
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "Sixth course",  Summary="This is an course description." }
            };

        }


        public async Task<bool> AddItemAsync(CourseModel item)
        {
            item.Id =   Guid.NewGuid().ToString();
            courses.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(CourseModel item)
        {
            var oldCourseModel = courses.Where((CourseModel arg) => arg.Id == item.Id).FirstOrDefault();
            courses.Remove(oldCourseModel);
            courses.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldCourseModel = courses.Where((CourseModel arg) => arg.Id == id).FirstOrDefault();
            courses.Remove(oldCourseModel);

            return await Task.FromResult(true);
        }

        public async Task<CourseModel> GetItemAsync(string id)
        {
            return await Task.FromResult(courses.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<CourseModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(courses);
        }
    }
}