using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veranstaltungssoftware
{
    class TableException : Exception
    {
        public TableException(string message) : base(message)
        {

        }

        public TableException()
        {

        }
    }
}
