using Calculate.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal class DoubleTryParse
    {
        public double doubleTryParse(string data)
        {
            double number;

            try
            {
                number = double.Parse(data);
                if (number < 0) 
                {
                    throw new NegativeNumberException("Вы ввели отрицательное число, по этому оно будет приравнено к 0");
                }
                return number;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

           /* while (!Double.TryParse(data, out number))
            {
                throw new FormatException();
                data = Console.ReadLine();
            }
            return number;
            }*/

            
           /* try
            {
                double num = double.Parse(data);
                if (num < 0)
                {
                    throw new NegativeNumberException();
                }
                else
                {
                    return num;
                    
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Это не число");
                return 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return 0;
            }*/
        }
    }
}
