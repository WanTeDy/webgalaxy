using System;

namespace WebGalaxy.Utils.Except
{
    public class ActionNotAllowedException : WebGalaxyException
    {
        public ActionNotAllowedException()
        {
        }

        public ActionNotAllowedException(string message) : base(message)
        {
        }

        public ActionNotAllowedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}