namespace Biblioteka.Entities
{
    public class Book
    {
        public int Book_ID { get; set; }
        public string Title { get; set; }

        public string Publisher { get; set; }
        public DateTime Publication_Date { get; set; }
        public int Quantity { get; set; }
        public int Autor_ID { get; set; }

        public virtual Autor Autor {get;set;}
    }
}
