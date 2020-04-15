using Course.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Course.Services
{
    public class MockCourseCategories : IDataStore<CourseCategory>
    {
        List<CourseCategory> CourseCategories;
        public MockCourseCategories()
        {
            CourseCategories = new List<CourseCategory>()
            {
                new CourseCategory{ Id = Guid.NewGuid().ToString(), Name = "History" },
                new CourseCategory{ Id = Guid.NewGuid().ToString(), Name = "Since" },
                new CourseCategory{ Id = Guid.NewGuid().ToString(), Name = "Arts" },
                new CourseCategory{ Id = Guid.NewGuid().ToString(), Name = "Politics" },
                new CourseCategory{ Id = Guid.NewGuid().ToString(), Name = "Economy" }
            };
        }
        public Task<bool> AddItemAsync(CourseCategory item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CourseCategory> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CourseCategory>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(CourseCategories);
        }

        public Task<bool> UpdateItemAsync(CourseCategory item)
        {
            throw new NotImplementedException();
        }
    }
}