using System;
using System.Collections.Generic;
using System.Text;

namespace surf_Board
{
    public class Rental
    {
        public string RentalID { get; set; }
        public string CustomerID { get; set; }
        public string Surfboard { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
    }

}
