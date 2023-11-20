using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.Exeptions
{
    internal class NegativeNumberException : Exception
    {
        public NegativeNumberException() { }
        public NegativeNumberException(string error) : base(error)
        {

        }
        public NegativeNumberException(string massage, Exception ex) : base(massage, ex)
        {

        }
    }
}
