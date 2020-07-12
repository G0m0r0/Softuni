﻿namespace P01_StudentSystem.Data.Models
{
    using P01_StudentSystem.Data.Models.enumerations;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        [Key]
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public Student Student { get; set; }
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Course Course { get; set; }
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
    }
}
