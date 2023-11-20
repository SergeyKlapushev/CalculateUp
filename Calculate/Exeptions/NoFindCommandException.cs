using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal class NoFindCommandException : Exception
    {
        public NoFindCommandException()
        {

        }
        public NoFindCommandException(string massage) : base(massage)
        {

        }
        public NoFindCommandException(string massage, Exception ex) : base(massage, ex)
        {

        }
    }
}
