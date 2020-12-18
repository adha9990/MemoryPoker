using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryPoker.Models
{
    class Poker
    {
        public Poker(int id,string value)
        {
            Id = id;
            Value = value;
        }
        public int Id
        {
            set;
            get;
        }
        public string Value
        {
            set;
            get;
        }
    }
}
