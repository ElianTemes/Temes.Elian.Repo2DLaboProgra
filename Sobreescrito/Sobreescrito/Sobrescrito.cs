using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescribir
{
    class Sobrescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Sobrescrito);
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
