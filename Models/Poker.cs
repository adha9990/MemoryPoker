using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryPoker.Models
{
    class Poker
    {
        public Poker(string value,string parents)
        {
            Value = value;
            Parents = parents;
        }
        public string Value
        {
            set;
            get;
        }
        public string Parents
        {
            set;
            get;
        }        
    }
}
