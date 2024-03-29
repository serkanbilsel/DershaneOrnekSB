namespace DershaneOrnekSB.Entities
{
    public class UserExamAttempt
    {
        public int Id { get; set; }
        public int UserExamAssignmentId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public List<QuestionAnswer> Answers { get; set; }
    }
}
