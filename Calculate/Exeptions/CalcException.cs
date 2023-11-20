using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.Exeptions
{
    internal class CalcException : Exception
    {
        public CalcException() { }
        public CalcException(string error) : base(error)
        {

        }
        public CalcException(string massage, Exception ex) : base(massage, ex)
        {

        }
    }
}
