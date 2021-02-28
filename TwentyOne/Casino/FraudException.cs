using System;
namespace Casino
{
    public class FraudException : Exception
    {
        // creating two constructors, one overrloading the other and having them implement the exact same implementation for exception 
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }
    }
}
