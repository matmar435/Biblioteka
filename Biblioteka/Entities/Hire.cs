namespace Biblioteka.Entities
{
    public class Hire
    {
        public int Hire_ID { get; set; }
        public DateTime Hire_Date { get; set; } 
        public DateTime Hire_End_Date { get; set; }
        public int Quantity { get; set; }
        public int Reader_ID { get; set; }
        public int Book_ID { get; set; }
        public int Employee_ID { get; set; }

        public virtual Reader Reader { get; set; }
        public virtual Book Book { get; set; }
        public virtual Employees Employees { get; set; }
    }
}
