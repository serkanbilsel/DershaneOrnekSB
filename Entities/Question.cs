namespace DershaneOrnekSB.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; } // Soru metni
        public bool IsMultipleChoice { get; set; } // Seçmeli mi?
        public string CorrectAnswer { get; set; } // Doğru cevap (sadece seçmeli sorular için)
        public string Explanation { get; set; } // Açıklama
    }
}
