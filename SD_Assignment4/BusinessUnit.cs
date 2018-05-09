using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class BusinessUnit
    {
        private int unitId;
        private string name;
        private string address;

        public int UnitId { get => unitId; set => unitId = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }

        public BusinessUnit(int unitId, string name, string address)
        {
            this.unitId = unitId;
            this.name = name;
            this.address = address;
        }

        public BusinessUnit() { }
    }
}
