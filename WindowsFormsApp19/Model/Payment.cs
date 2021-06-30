using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public string Oil { get; set; }
        public int Litr { get; set; }
        public double Total { get; set; }
        public string Meals { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public override string ToString()
        {

            return $"{Oil} - {Litr} lt - Meals : {Meals} - {Total} azn - {PaymentDate}";
        }
    }
}
