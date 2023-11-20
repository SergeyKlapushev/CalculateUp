using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.Interfaces
{
    public interface ICalculate
    {
        public double calculateSum(double num1, double num2);
        public double calculateSub(double num1, double num2);
        public double calculateMult(double num1, double num2);
        public double calculateDiv(double num1, double num2);
    }
}
