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
        public Data(string chinese,string english)
        {
            Chinese = chinese;
            English = english;
        }
        public string Chinese
        {
            get;
            set;
        }
        public string English
        {
            get;
            set;
        }
    }
}
