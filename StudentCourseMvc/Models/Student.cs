using System.ComponentModel.DataAnnotations;

namespace StudentCourseMvc.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set;}
      
    }
}
