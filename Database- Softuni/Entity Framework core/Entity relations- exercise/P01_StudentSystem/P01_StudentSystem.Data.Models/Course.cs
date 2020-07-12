﻿namespace P01_StudentSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        public Course()
        {
            Resources = new HashSet<Resource>();
            HomeworkSubmissions = new HashSet<HomeworkSubmission>();
            StudentCourses = new HashSet<StudentCourse>();
        }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}