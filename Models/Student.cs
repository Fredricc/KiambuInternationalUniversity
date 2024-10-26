namespace KiambuInternationalUniversity.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime RegestrationDate { get; set; }
        public bool Subsription { get; set; }
    }
}
