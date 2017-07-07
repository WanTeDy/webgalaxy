using System;
using System.ComponentModel.DataAnnotations;

namespace WebGalaxy.Utils.Objects.Requests
{
    public class RequestCreateUserMail
    {
        public String Name { get; set; }

        public String Email { get; set; }

        public String Phone { get; set; }

        public String Message { get; set; }
    }
}