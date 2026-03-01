namespace SumApi.Models
{
    public class SumRecord
    {
        public int Id { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}