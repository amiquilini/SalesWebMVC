using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class SameIdException : ApplicationException
    {
        public SameIdException(string message) : base(message)
        {
        }
    }
}
