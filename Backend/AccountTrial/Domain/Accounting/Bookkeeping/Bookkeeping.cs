using Domain.Accounting.Bookkeeping.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Accounting.Bookkeeping
{
    public sealed class Bookkeepin
    {
        public Credit Credit { get; set; }
        public Debit Debit { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
