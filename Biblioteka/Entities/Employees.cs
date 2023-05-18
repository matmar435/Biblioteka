namespace Biblioteka.Entities
{
    public class Employees
    {
        public int Employee_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Pesel { get; set; }
        public string PasswordHash { get; set; }
        public int Wynagrodzenie { get; set; }
        public int Role_ID { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
