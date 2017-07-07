using System;
using System.Collections.Generic;

namespace WebGalaxy.Utils.Entities
{
    public class UserMail : BaseObj
    {
        /// <summary>
        /// user's name
        /// </summary>       
        public String Name { get; set; }
        /// <summary>
        /// user's email
        /// </summary>       
        public String Email { get; set; }
        /// <summary>
        /// user's phone
        /// </summary>       
        public String Phone { get; set; }
        /// <summary>
        /// Message
        /// </summary> 
        public String Message { get; set; }
        
        /// <summary>
        /// datetime
        /// </summary> 
        public DateTime Date { get; set; }
    }
}