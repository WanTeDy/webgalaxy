using System;
using System.Collections.Generic;

namespace WebGalaxy.Utils.Entities
{
    public class UserFeedback : BaseObj
    {
        /// <summary>
        /// user's name
        /// </summary>       
        public String Name { get; set; }
        /// <summary>
        /// user's company
        /// </summary>       
        public String Company { get; set; }
        /// <summary>
        /// Message
        /// </summary> 
        public String Message { get; set; }
        
        /// <summary>
        /// datetime
        /// </summary> 
        public DateTime Date { get; set; }

        public Boolean IsApproved { get; set; }
    }
}