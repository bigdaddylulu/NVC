using System;

namespace nvc.Services
{
    public class InvalidTruckConfigurationException : Exception
    {
        public InvalidTruckConfigurationException(string message) : base(message)
        {
        }
    }
}