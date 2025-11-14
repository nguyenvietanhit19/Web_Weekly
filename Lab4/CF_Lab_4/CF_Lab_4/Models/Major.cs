namespace CF_Lab_4.Models
{
    public class Major
    {
        public int MajorID { get; set; }
        public string MajorName { get; set; }

        // 1 Major có nhiều Learner
        public ICollection<Learner> Learners { get; set; }
            = new HashSet<Learner>();
    }
}
