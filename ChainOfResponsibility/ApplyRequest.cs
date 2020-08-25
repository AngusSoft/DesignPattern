using System;

namespace ChainOfResponsibility
{
    public class ApplyRequest
    {
        public decimal Amount;
        public ApplyRequest(decimal amount)
        {
            Amount = amount;
        }
    }
}
