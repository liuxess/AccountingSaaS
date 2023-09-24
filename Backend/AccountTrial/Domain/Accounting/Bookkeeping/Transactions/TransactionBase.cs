using Domain.Accounting.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Accounting.Bookkeeping.Transactions
{
    public abstract class TransactionBase
    {
        public int AccountId { get; set; }
        public int Account { get; set; }
        public Currency Currency { get; set; }
    }
}
