using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class PrototypeManager : IPrototype<Prototype>
    {
        private Dictionary<int, Prototype> _amimals = new Dictionary<int, Prototype>();

        public Prototype this[int key]
        {
            get { return _amimals[key]; }
            set { _amimals.Add(key, value); }
        }
    }
}
