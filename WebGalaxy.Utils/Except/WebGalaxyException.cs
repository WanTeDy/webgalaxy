using System;

namespace WebGalaxy.Utils.Except
{
    public class WebGalaxyException : Exception
    {
        public WebGalaxyException()
        {
        }

        public WebGalaxyException(string message) : base(message)
        {
        }

        public WebGalaxyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}