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
