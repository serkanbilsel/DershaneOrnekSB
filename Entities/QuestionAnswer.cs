namespace DershaneOrnekSB.Entities
{
    public class QuestionAnswer
    {
        public int Id { get; set; } // Birincil anahtar olarak belirtilen Id özelliği
        public int QuestionId { get; set; }
        public int? SelectedChoiceId { get; set; }
    }
}
