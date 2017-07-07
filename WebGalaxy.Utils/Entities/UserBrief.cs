using System;
using System.Collections.Generic;

namespace WebGalaxy.Utils.Entities
{
    public class UserBrief : BaseObj
    {
        public String Name { get; set; }

        public String Email { get; set; }

        public String Message { get; set; }

        public String Phone { get; set; }

        public String AboutCompany { get; set; }

        public String SiteExamples { get; set; }

        public String Languages { get; set; }

        public String RealizationDates { get; set; }

        public Boolean Promo { get; set; }
        public Boolean Corporative { get; set; }
        public Boolean Shop { get; set; }
        public Boolean Blog { get; set; }
        public Boolean Cutaway { get; set; }

        /// <summary>
        /// datetime
        /// </summary> 
        public DateTime Date { get; set; }

        public Boolean IsRead { get; set; }
    }
}