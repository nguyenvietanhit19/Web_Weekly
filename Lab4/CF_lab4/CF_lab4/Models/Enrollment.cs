namespace CF_lab4.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        // Khóa ngoại → Course
        public int CourseID { get; set; }
        public Course Course { get; set; }

        // Khóa ngoại → Learner
        public int LearnerID { get; set; }
        public Learner Learner { get; set; }

        public float Grade { get; set; }
    }
}
