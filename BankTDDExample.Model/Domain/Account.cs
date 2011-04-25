using System.Collections.Generic;

namespace BankTDDExample.Model.Domain
{
    public abstract class Account
    {
        public long Id { get; set; }
        public AccountType AccountType { get; set; }
        public IList<Movement> Movements { get; set; }
    }

    public enum AccountType
    {
        CuentaCorriente = 0,
        CajaDeAhorro = 1,
    }
}
