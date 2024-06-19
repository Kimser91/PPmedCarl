using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PPmedCarl
{
    internal class Store
    {

        public string Name;
        public string Type;
        public int PriceClass;

        public Store()
        {

        }
        public Store(string name, string type, int priceClass)
        {
            Name = name;
            Type = type;
            PriceClass = priceClass;
        }

        
    }
}
