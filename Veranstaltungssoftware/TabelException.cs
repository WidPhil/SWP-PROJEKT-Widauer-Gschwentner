using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veranstaltungssoftware
{
    class TabelException : Exception
    {
        public TabelException(string message) : base(message)
        {

        }

        public TabelException()
        {

        }
    }
}
