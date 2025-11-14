using System.ComponentModel.DataAnnotations.Schema;

namespace CF_Lab_4.Models
{
    public class Course
    {
        // Không tự tăng → phải nhập thủ công
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        public string Title { get; set; }
        public int Credits { get; set; }

        // 1 Course có nhiều Enrollment
        public ICollection<Enrollment> Enrollments { get; set; }
            = new HashSet<Enrollment>();
    }
}
