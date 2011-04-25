using System.Collections.Generic;

namespace BankTDDExample.Model.Domain
{
    public class Client
    {
        public long Id { get; set; }
        public IList<Account> Accounts { get; set; }
    }
}
