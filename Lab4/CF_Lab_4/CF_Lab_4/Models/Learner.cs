namespace CF_Lab_4.Models
{
    public class Learner
    {
        public int LearnerID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime? EnrollmentDate { get; set; }


        // Khóa ngoại tới Major
        public int MajorID { get; set; }
        public Major Major { get; set; }

        // 1 Learner có nhiều Enrollment (đăng ký học)
        public ICollection<Enrollment> Enrollments { get; set; }
            = new HashSet<Enrollment>();
    }
}
