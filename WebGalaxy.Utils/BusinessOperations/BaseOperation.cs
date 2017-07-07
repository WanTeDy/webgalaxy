using System;
using System.Collections.Generic;
using WebGalaxy.Utils.DataBase;

namespace WebGalaxy.Utils.BusinessOperations
{
    public class BaseOperation
    {
        /// <summary>
        /// Context
        /// </summary>
        public DbWebGalaxy Context { get; set; }

        public BaseOperation()
        {
            Name = getShortName(GetType().ToString());
            Errors = new Dictionary<string, string>();
        }

        /// <summary>
        /// Name of bissnes operation
        /// </summary>
        public String Name
        {
            get;
            protected set;
        }
        public String RussianName
        {
            get;
            protected set;
        }

        public IDictionary<String, String> Errors
        {
            get;
            protected set;
        }

        public Boolean Success
        {
            get
            {
                return Errors.Count > 0 ? false : true;
            }
        }

        protected virtual void PrepareAndCheck()
        { }

        protected virtual void PerformOperation()
        { }

        protected virtual void CloseOperation()
        { }

        /// <summary>
        /// Excecute all transaction
        /// </summary>
        public void ExcecuteTransaction()
        {

            Context = new DbWebGalaxy();

            PerformOperation();
            //отрытие тр.
            PrepareAndCheck();
            //выполнение тр.

            CloseOperation();
        }
        private static string getShortName(string str)
        {
            int start = str.LastIndexOf('.') + 1;
            int end = str.LastIndexOf("Operation");
            return str.Substring(start, end - start).ToLower();
        }
    }
}