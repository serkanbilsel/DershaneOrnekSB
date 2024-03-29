namespace DershaneOrnekSB.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CategoryId { get; set; } // Kategorinin Id'si
        public Category Category { get; set; } // Kategori nesnesi
        public List<Question> Questions { get; set; } = new List<Question>(); // Sınavdaki sorular

    }
}

