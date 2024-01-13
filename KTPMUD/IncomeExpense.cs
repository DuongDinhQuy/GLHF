using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPMUD
{
    internal class IncomeExpense
    {
        public int ID { get; set; }
        public string UsersAcc { get; set; }
        public int Amount { get; set; }
        public int CategoryId { get; set; }
        public DateTime IEDate { get; set; }
    }
}
