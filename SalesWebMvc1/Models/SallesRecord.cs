using System;
namespace SalesWebMvc1.Models
{
    public class SallesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public  double Amount { get; set; }
        public SallesRecord Status { get; set; }
        public Seller Seller { get; set; }

        public SallesRecord()
        {

        }

        public SallesRecord(int id, DateTime date, double amount, SallesRecord status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
   
