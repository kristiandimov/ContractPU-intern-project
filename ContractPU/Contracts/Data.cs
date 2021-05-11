using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractPU.Contracts
{
    public class Data
    {

        public int contractNum { get; set; }
        public DateTime contractDate { get; set; }
        public int contragentId { get; set; }
        public int courseId { get; set; }
        public int educatorId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public decimal priceWithCredit { get; set; }
        public decimal totalWihtCredit { get; set; }
        public decimal priceWithoutCredit { get; set; }
        public decimal totalWihtoutCredit { get; set; }
        public decimal DDS { get; set; }
        public decimal DKPRPS { get; set; }
        public decimal honorar { get; set; }
        public decimal materialExprenses { get; set; }
        
    }
}
