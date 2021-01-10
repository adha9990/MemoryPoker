using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryPoker.Models
{
    class Data
    {
        public Data() { 

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="english"></param>
        /// <param name="chinese"></param>
        public Data(string english, string chinese)
        {
            English = english;
            Chinese = chinese;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="english"></param>
        /// <param name="chinese"></param>
        public Data(int id, string english, string chinese)
        {
            Id = id;
            English = english;
            Chinese = chinese;
        }
        public int Id
        {
            get;
            set;
        }
        public string English
        {
            get;
            set;
        }
        public string Chinese
        {
            get;
            set;
        }
    }
}
