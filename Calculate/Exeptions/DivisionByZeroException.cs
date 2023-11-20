using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.Exeptions
{
    internal class DivisionByZeroException : Exception
    {
        public DivisionByZeroException()
        {

        }
        public DivisionByZeroException(string error) : base(error)
        {

        }
        public DivisionByZeroException(string error, double number) : base(error)
        {
            number *= -1;
        }
        public DivisionByZeroException(string massage, Exception ex) : base(massage, ex)
        {

        }
    }
}
