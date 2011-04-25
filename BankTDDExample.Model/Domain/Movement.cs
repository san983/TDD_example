namespace BankTDDExample.Model.Domain
{
    public class Movement
    {
        public long Id { get; set; }
        public MovementType MovementType { get; set;}
    }

    public enum MovementType
    {
        Deposit = 0,
        Extract = 1
    }
}
