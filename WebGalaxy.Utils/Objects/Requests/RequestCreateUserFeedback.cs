using System;
using System.ComponentModel.DataAnnotations;

namespace WebGalaxy.Utils.Objects.Requests
{
    public class RequestCreateUserFeedback
    {
        public String Name { get; set; }

        public String Company { get; set; }

        public String Message { get; set; }
    }
}