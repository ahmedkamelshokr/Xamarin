using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Course.Models
{
    public class CourseModel
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Summary { get; set; }
        [EmailAddress]
        public string AuthorEmail { get; set; }
        public CourseCategory Category { get; set; }

    }

    public class CourseCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
