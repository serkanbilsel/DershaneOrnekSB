namespace DershaneOrnekSB.Entities
{
    public class UserExamAssignment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public DateTime AssignmentDate { get; set; }
    }

}
