using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDebtSystem
{
    public class Customer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Tarih { get; set; }
        public string İsim { get; set; }
        public string Açıklama { get; set; }
        public decimal Borç { get; set; }
        public decimal Alacak { get; set; }

    }
}
