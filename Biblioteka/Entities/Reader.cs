namespace Biblioteka.Entities
{
    public class Reader
    {
        public int Reader_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Pesel { get; set; }
        public string PasswordHash { get; set; }
    }
}
